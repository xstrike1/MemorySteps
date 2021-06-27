using System;
using System.Diagnostics;
using System.Linq;
using FlaUI.Core.Exceptions;
using Microsoft.Test.Input;
using MemoryStepsCore.Models;
using MemoryStepsCore.Config;
using System.Drawing;
using System.Timers;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace MemoryStepsCore.Services
{
    public class CursorExecutorService
    {
        private readonly CursorRegisterService _cursorRegister;
        private CurrentCursorProcessModel _currentlyProcessingCursor;
        private IMemoryProcessingForm _processingForm;
        private IMemoryMainForm _parentForm;
        private long _execTimer = 0;
        private readonly long _timerInterval = 100;
        private System.Timers.Timer _timer;

        public CursorExecutorService(CursorRegisterService cursorRegister)
        {
            _cursorRegister = cursorRegister;
        }

        public long GetTotalDuration()
        {
            return _cursorRegister.TestConfig.CursorList.Sum(cursor => cursor.MilisecondsToNextCursor);
        }

        public void Execute(IMemoryMainForm parentForm)
        {
            if (_cursorRegister == null || _cursorRegister.TestConfig.CursorList.Count == 0)
            {
                return;
            }

            Stopwatch stopWatch = new();
            stopWatch.Start();
            _parentForm = parentForm;
            var totalDuration = GetTotalDuration();
            var autoclickerForm = parentForm.CreateProcessingForm(parentForm, this, totalDuration);
            Application.DoEvents();

            InternalExecute(parentForm, autoclickerForm);
        }

        private void InternalExecute(IMemoryMainForm parentForm, IMemoryProcessingForm autoclickerForm)
        {
            _processingForm = autoclickerForm;
            ExecuteMouseClick(_cursorRegister.TestConfig.CursorList[0]);
            GoToNextCursor(_cursorRegister.TestConfig.CursorList[0]);
        }

        private static void ExecuteMouseClick(CursorEntity cursor)
        {
            Mouse.MoveTo(cursor.Position);

            var st = new Stopwatch();
            st.Start();
            var controlIsGood = IsMouseOverControl(cursor, st);

            if (!controlIsGood)
                throw new ApplicationException("Control not found!");

            if (cursor.DragPosition != Point.Empty)
            {
                Mouse.DragTo(cursor.ButtonPressed, cursor.DragPosition);
                return;
            }

            if (cursor.MouseWheelDelta != 0)
            {
                Mouse.Scroll(cursor.MouseWheelDelta / SystemInformation.MouseWheelScrollDelta);
                return;
            }

            if (cursor.DoubleClick)
                Mouse.DoubleClick(cursor.ButtonPressed);
            else
                Mouse.Click(cursor.ButtonPressed);
        }

        private void GoToNextCursor(CursorEntity cursor)
        {
            var prevCursor = cursor.CursorNumber == 1 ? null : _cursorRegister.TestConfig.CursorList[cursor.CursorNumber - 2];
            var currentCursor = _cursorRegister.TestConfig.CursorList[cursor.CursorNumber - 1];
            var nextCursor = cursor.CursorNumber < _cursorRegister.TestConfig.CursorList.Count  ? _cursorRegister.TestConfig.CursorList[cursor.CursorNumber] : null;
            _processingForm.Invoke(new Action(() => _processingForm.Executor_StepCompleted(prevCursor == null ? 0 : prevCursor.MilisecondsToNextCursor, currentCursor, nextCursor)));

            if (nextCursor == null)
            {
                StopTimer();
                _parentForm.Invoke(new Action(() =>_parentForm.CloseProcessingForm()));
                return;
            }
            ExecuteCursor(nextCursor, currentCursor);
        }

        private void ExecuteCursor(CursorEntity cursor, CursorEntity previousCursor)
        {
            StartTimer();

            long firstCharacterMs = 0;
            var charactersPressed = false;

            if (previousCursor.PressedCharacters.Count > 0)
                firstCharacterMs = previousCursor.PressedCharacters.FirstOrDefault().Key;
            else
                charactersPressed = true;

            _currentlyProcessingCursor = new CurrentCursorProcessModel()
            {
                PrevCursor = previousCursor,
                CurrentCursor = cursor,
                CharactersPressed = charactersPressed,
                FirstCharTime = firstCharacterMs
            };
        }

        private  void OnTimerTick(object sender, ElapsedEventArgs e)
        {
            _execTimer += _timerInterval;

            if (_processingForm.CancelHasBeenRequested)
            {
                StopTimer();
                _parentForm.CloseProcessingForm();
                return;
            }

            if (_execTimer > _currentlyProcessingCursor.PrevCursor.MilisecondsToNextCursor)
            {
                StopTimer();
                ExecuteMouseClick(_currentlyProcessingCursor.CurrentCursor);
                GoToNextCursor(_currentlyProcessingCursor.CurrentCursor);
                return;
            }

            if (_currentlyProcessingCursor.CharactersPressed || _currentlyProcessingCursor.FirstCharTime == 0 ||
                _execTimer <= _currentlyProcessingCursor.FirstCharTime)
                return;

            foreach (var value in _currentlyProcessingCursor.PrevCursor.PressedCharacters.Values)
                _processingForm.Invoke(new Action(() => _processingForm.SendKey(value.ToString())));
             
            _currentlyProcessingCursor.CharactersPressed = true;
        }

        private void StartTimer()
        {
            _timer = new();
            _timer.Interval = _timerInterval;
            _timer.Elapsed += OnTimerTick;
            _timer.Start();
        }

        private void StopTimer() 
        {
            _execTimer = 0;
            if (_timer == null)
                return;

            _timer.Stop();
            _timer.Elapsed -= OnTimerTick;
        }

        private static bool IsMouseOverControl(CursorEntity cursor, Stopwatch st)
        {
            if (cursor.ControlType == AppConfig.Config.Undefined) return true;

            while (true) //TODO change this
            {
                var r = AutomationService.GetHoveredElement();
                if (st.ElapsedMilliseconds > AppConfig.Config.MaxActionDelay) return false;
                try
                {
                    if (cursor.ControlType == "" || r == null ||
                        r.ControlType.ToString() != cursor.ControlType)
                        continue;

                    if (AppConfig.Config.CheckControlName && r.Name != cursor.ControlName)
                        continue;

                    ElementHighlighter.HighlightElement(r, Color.BlueViolet);
                    return true;
                }
                catch (PropertyNotSupportedException)
                {
                    Thread.Sleep(50);
                }
                finally
                {
                    Thread.Sleep(200);
                }
            }
        }
    }

}
