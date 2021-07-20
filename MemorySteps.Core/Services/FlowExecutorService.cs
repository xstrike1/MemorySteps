using FlaUI.Core.Exceptions;
using MemorySteps.Core.Config;
using MemorySteps.Core.Interfaces;
using MemorySteps.Core.Models;
using Microsoft.Test.Input;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Timers;
using System.Windows.Forms;

namespace MemorySteps.Core.Services
{
    public class FlowExecutorService : IFlowExecutorService
    {
        private IFlowRegisterService _flowRegister;
        private IMemoryProcessingWindow _processingWindow;
        private IMemoryMainWindow _parentWindow;

        private long _execTimer;
        private readonly long _timerInterval = 100;
        private System.Timers.Timer _timer;
        private CurrentlyProcessingAction _currentlyProcessingAction;

        public FlowExecutorService(IFlowRegisterService flowRegisterService)
        {
            _flowRegister = flowRegisterService;
        }

        public long GetTotalDuration()
        {
            return _flowRegister.FlowConfig.UserActionList.Sum(cursor => cursor.MilisecondsToNextAction);
        }

        public void Execute(IMemoryMainWindow parentForm)
        {
            if (_flowRegister == null || _flowRegister.FlowConfig.UserActionList.Count == 0)
            {
                return;
            }

            Stopwatch stopWatch = new();
            stopWatch.Start();
            _parentWindow = parentForm;
            long totalDuration = GetTotalDuration();
            IMemoryProcessingWindow autoclickerForm = parentForm.ShowProcessingFormOnExecute(parentForm, this, totalDuration);
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

            if (_execTimer > _currentlyProcessingAction.PreviousAction.MilisecondsToNextAction)
            {
                StopTimer(OnTimerTickForActionDelay);
                ExecuteMouseAction(_currentlyProcessingAction.CurrentAction);
                return;
            }

            if (_currentlyProcessingAction.CharactersPressed || _currentlyProcessingAction.FirstCharTime == 0 ||
                _execTimer <= _currentlyProcessingAction.FirstCharTime)
                return;

            _currentlyProcessingAction.CharactersPressed = true;

            foreach (char value in _currentlyProcessingAction.PreviousAction.PressedCharacters.Values)
                _processingWindow.Invoke(new Action(() => _processingWindow.SendKey(value.ToString())));

        }

        private void OnTimerTickForControlChecking(object sender, ElapsedEventArgs e)
        {
            _execTimer += _timerInterval;
            if (CancelHasBeenRequested(OnTimerTickForControlChecking))
                return;

            if (_execTimer > AppConfig.Config.MaxActionDelay)
            {
                StopTimer(OnTimerTickForControlChecking);
                _parentWindow.Invoke(new Action(() => _parentWindow.DisplayMessage($"Control for cursor action #{_currentlyProcessingAction.CurrentAction.ActionNumber} could not be found", "Error")));
                _parentWindow.Invoke(new Action(() => _parentWindow.CloseProcessingForm()));
            }

            FlaUI.Core.AutomationElements.AutomationElement hoveredElement = AutomationService.GetHoveredElement();
            try
            {
                if (_currentlyProcessingAction.CurrentAction.ControlType == "" || hoveredElement == null ||
                    hoveredElement.ControlType.ToString() != _currentlyProcessingAction.CurrentAction.ControlType)
                    return;

                if (AppConfig.Config.CheckControlName && hoveredElement.Name != _currentlyProcessingAction.CurrentAction.ControlName)
                    return;

                ElementHighlighterService.HighlightElement(hoveredElement, Color.BlueViolet);
                ExecuteMouseClick(_currentlyProcessingAction.CurrentAction);
            }
            catch (PropertyNotSupportedException)
            {
                //hoveredElement is not supported
            }
        }

        private void InternalStartExecute(IMemoryProcessingWindow autoclickerForm)
        {
            _processingWindow = autoclickerForm;

            _currentlyProcessingAction = new CurrentlyProcessingAction()
            {
                PreviousAction = null,
                CurrentAction = _flowRegister.FlowConfig.UserActionList[0],
                FirstCharTime = 0
            };

            Mouse.MoveTo(_flowRegister.FlowConfig.UserActionList[0].Position);
            ExecuteMouseClick(_flowRegister.FlowConfig.UserActionList[0]);
        }

        private void GoToNextCursor(UserAction cursor)
        {
            UserAction prevCursor = cursor.ActionNumber == 1 ? null : _flowRegister.FlowConfig.UserActionList[cursor.ActionNumber - 2];
            UserAction currentCursor = _flowRegister.FlowConfig.UserActionList[cursor.ActionNumber - 1];
            UserAction nextCursor = cursor.ActionNumber < _flowRegister.FlowConfig.UserActionList.Count ? _flowRegister.FlowConfig.UserActionList[cursor.ActionNumber] : null;
            _processingWindow.Invoke(new Action(() => _processingWindow.Executor_StepCompleted(prevCursor == null ? 0 : prevCursor.MilisecondsToNextAction, currentCursor, nextCursor)));

            if (nextCursor == null)
            {
                StopTimer(OnTimerTickForActionDelay);
                _parentWindow.Invoke(new Action(() => _parentWindow.CloseProcessingForm()));
                return;
            }
            ExecuteCursor(nextCursor, currentCursor);
        }

        private void ExecuteCursor(UserAction cursor, UserAction previousCursor)
        {
            StartTimer(OnTimerTickForActionDelay);

            long firstCharacterMs = 0;
            bool charactersPressed = false;

            if (previousCursor.PressedCharacters.Count > 0)
                firstCharacterMs = previousCursor.PressedCharacters.FirstOrDefault().Key;
            else
                charactersPressed = true;

            _currentlyProcessingAction = new CurrentlyProcessingAction()
            {
                PreviousAction = previousCursor,
                CurrentAction = cursor,
                CharactersPressed = charactersPressed,
                FirstCharTime = firstCharacterMs
            };
        }

        private void ExecuteMouseAction(UserAction cursor)
        {
            Mouse.MoveTo(cursor.Position);
            if (cursor.ControlType == AppConfig.Config.Undefined)
            {

                ExecuteMouseClick(cursor);
                return;
            }

            StartTimer(OnTimerTickForControlChecking);
        }

        private void ExecuteMouseClick(UserAction cursor)
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

            GoToNextCursor(_currentlyProcessingAction.CurrentAction);
        }

        private bool CancelHasBeenRequested(ElapsedEventHandler elapsedEventHandler)
        {
            if (_processingWindow.CancelHasBeenRequested)
            {
                StopTimer(elapsedEventHandler);
                _parentWindow.Invoke(new Action(() => _parentWindow.CloseProcessingForm()));
                return true;
            }
            return false;
        }
    }
}
