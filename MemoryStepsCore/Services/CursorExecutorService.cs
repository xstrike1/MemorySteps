using System;
using System.Diagnostics;
using System.Linq;
using FlaUI.Core.Exceptions;
using Microsoft.Test.Input;
using MemoryStepsCore.Models;
using MemoryStepsCore.Config;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

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

            InternalStartExecute(autoclickerForm);
        }

        private void StartTimer(ElapsedEventHandler elapsedEventHandler)
        {
            _timer = new();
            _timer.Interval = _timerInterval;
            _timer.Elapsed += elapsedEventHandler;
            _timer.Start();
        }

        private void StopTimer(ElapsedEventHandler elapsedEventHandler)
        {
            _execTimer = 0;
            if (_timer == null)
                return;

            _timer.Stop();
            _timer.Elapsed -= elapsedEventHandler;
        }

        private void OnTimerTickForActionDelay(object sender, ElapsedEventArgs e)
        {
            _execTimer += _timerInterval;

            if (CancelHasBeenRequested(OnTimerTickForActionDelay))
                return;

            if (_execTimer > _currentlyProcessingCursor.PrevCursor.MilisecondsToNextCursor)
            {
                StopTimer(OnTimerTickForActionDelay);
                ExecuteMouseAction(_currentlyProcessingCursor.CurrentCursor);
                return;
            }

            if (_currentlyProcessingCursor.CharactersPressed || _currentlyProcessingCursor.FirstCharTime == 0 ||
                _execTimer <= _currentlyProcessingCursor.FirstCharTime)
                return;

            foreach (var value in _currentlyProcessingCursor.PrevCursor.PressedCharacters.Values)
                _processingForm.Invoke(new Action(() => _processingForm.SendKey(value.ToString())));

            _currentlyProcessingCursor.CharactersPressed = true;
        }

        private void OnTimerTickForControlChecking(object sender, ElapsedEventArgs e)
        {
            _execTimer += _timerInterval;
            if (CancelHasBeenRequested(OnTimerTickForControlChecking))
                return;

            if (_execTimer > AppConfig.Config.MaxActionDelay)
            {
                StopTimer(OnTimerTickForControlChecking);
                _parentForm.Invoke(new Action(() => _parentForm.DisplayMessage($"Control for cursor action #{_currentlyProcessingCursor.CurrentCursor.CursorNumber} could not be found", "Error")));
                _parentForm.Invoke(new Action(() => _parentForm.CloseProcessingForm()));
            }

            var hoveredElement = AutomationService.GetHoveredElement();
            try
            {
                if (_currentlyProcessingCursor.CurrentCursor.ControlType == "" || hoveredElement == null ||
                    hoveredElement.ControlType.ToString() != _currentlyProcessingCursor.CurrentCursor.ControlType)
                    return;

                if (AppConfig.Config.CheckControlName && hoveredElement.Name != _currentlyProcessingCursor.CurrentCursor.ControlName)
                    return;

                ElementHighlighter.HighlightElement(hoveredElement, Color.BlueViolet);
                ExecuteMouseClick(_currentlyProcessingCursor.CurrentCursor);
            }
            catch (PropertyNotSupportedException)
            {
                //hoveredElement is not supported
            }
        }

        private void InternalStartExecute(IMemoryProcessingForm autoclickerForm)
        {
            _processingForm = autoclickerForm;

            _currentlyProcessingCursor = new CurrentCursorProcessModel()
            {
                CurrentCursor = _cursorRegister.TestConfig.CursorList[0]
            };

            Mouse.MoveTo(_cursorRegister.TestConfig.CursorList[0].Position);
            ExecuteMouseClick(_cursorRegister.TestConfig.CursorList[0]);
        }

        private void GoToNextCursor(CursorEntity cursor)
        {
            var prevCursor = cursor.CursorNumber == 1 ? null : _cursorRegister.TestConfig.CursorList[cursor.CursorNumber - 2];
            var currentCursor = _cursorRegister.TestConfig.CursorList[cursor.CursorNumber - 1];
            var nextCursor = cursor.CursorNumber < _cursorRegister.TestConfig.CursorList.Count ? _cursorRegister.TestConfig.CursorList[cursor.CursorNumber] : null;
            _processingForm.Invoke(new Action(() => _processingForm.Executor_StepCompleted(prevCursor == null ? 0 : prevCursor.MilisecondsToNextCursor, currentCursor, nextCursor)));

            if (nextCursor == null)
            {
                StopTimer(OnTimerTickForActionDelay);
                _parentForm.Invoke(new Action(() => _parentForm.CloseProcessingForm()));
                return;
            }
            ExecuteCursor(nextCursor, currentCursor);
        }

        private void ExecuteCursor(CursorEntity cursor, CursorEntity previousCursor)
        {
            StartTimer(OnTimerTickForActionDelay);

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

        private void ExecuteMouseAction(CursorEntity cursor)
        {
            Mouse.MoveTo(cursor.Position);
            if (cursor.ControlType == AppConfig.Config.Undefined)
            {

                ExecuteMouseClick(cursor);
                return;
            }

            StartTimer(OnTimerTickForControlChecking);
        }

        private  void ExecuteMouseClick(CursorEntity cursor)
        {
            StopTimer(OnTimerTickForControlChecking);

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

            GoToNextCursor(_currentlyProcessingCursor.CurrentCursor);
        }

        private bool CancelHasBeenRequested(ElapsedEventHandler elapsedEventHandler)
        {
            if (_processingForm.CancelHasBeenRequested)
            {
                StopTimer(elapsedEventHandler);
                _parentForm.Invoke(new Action(() => _parentForm.CloseProcessingForm()));
                return true;
            }
            return false;
        }
    }
}
