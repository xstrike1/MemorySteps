using MemorySteps.Core.Models;
using Microsoft.Test.Input;
using System.Drawing;
using System.Windows.Forms;
using FlaUI.Core.Definitions;
using FlaUI.Core.Exceptions;
using MemorySteps.Core.Config;
using System;
using Gma.System.MouseKeyHook;
using System.Collections.Generic;
using MemorySteps.Core.Interfaces;

namespace MemorySteps.Core.Services
{
    public class FlowRegisterService : IFlowRegisterService
    {
        private Action OnRegisterFinish; //idk if it's still needed, maybe not
        private IKeyboardMouseEvents _globalHook;
        private IMouseEventHandlers _mouseEventHandlers;
        bool mouseDragStarted;
        private IFlow _flowConfig;

        public IFlow FlowConfig { get => _flowConfig; set => _flowConfig = value; }

        public FlowRegisterService(IFlow flowConfig, IMouseEventHandlers mouseEventHandlers)
        {
            _flowConfig = flowConfig;
            _mouseEventHandlers = mouseEventHandlers;
        }

        public void StartFlowRegister()
        {
            FlowConfig.UserActionList = new List<UserAction>();

            _mouseEventHandlers.MouseClickEventHandler = GlobalHook_MouseClick;
            _mouseEventHandlers.MouseDoubleClickEventHandler = GlobalHook_MouseDoubleClick;
            _mouseEventHandlers.MouseDragStartedEventHandler = GlobalHook_MouseDragStarted;
            _mouseEventHandlers.MouseDragFinishedEventHandler = GlobalHook_MouseDragFinished;
            if (!AppConfig.Config.DisableMouseScrollCapture)
                _mouseEventHandlers.MouseWheelEventHandler = GlobalHook_MouseWheel;

            Subscribe();
        }

        private void Subscribe()
        {
            _globalHook = GlobalHookService.SubscribeGlobalHook(GlobalHookKeyPress, _mouseEventHandlers);
        }

        private void Unsubscribe()
        {
            GlobalHookService.UnsubscribeGlobalHook(_globalHook, GlobalHookKeyPress, _mouseEventHandlers);

            StopLastCursorTimer();
        }

        private void GlobalHookKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == AppConfig.Config.KeyBind)
            {
                AutomationService.StopTimer();
                Unsubscribe();
                e.Handled = true;
                OnRegisterFinish?.Invoke();
                return;
            }

            RegisterKeyPress(e.KeyChar);
            e.Handled = true;
        }

        private void GlobalHook_MouseClick(object sender, MouseEventArgs e)
        {
            if (mouseDragStarted)
                return;

            RegisterMouseButtonClick(e.Location, e.Button);
        }

        private void GlobalHook_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RegisterMouseDoubleClick();
        }

        private void GlobalHook_MouseWheel(object sender, MouseEventArgs e)
        {
            RegisterMouseWheel(e.Location, e.Delta);
        }

        private void GlobalHook_MouseDragStarted(object sender, MouseEventArgs e)
        {
            mouseDragStarted = true;
            RegisterMouseButtonClick(e.Location, e.Button);
        }

        private void GlobalHook_MouseDragFinished(object sender, MouseEventArgs e)
        {
            mouseDragStarted = false;
            FlowConfig.UserActionList[^1].DragPosition = e.Location;
        }

        private void RegisterKeyPress(char key)
        {
            if (FlowConfig.UserActionList.Count < 1)
                return;

            var currentCursor = FlowConfig.UserActionList[^1];
            currentCursor.PressedCharacters.Add(currentCursor.InternalStopwatch.ElapsedMilliseconds, key);
        }

        private void RegisterMouseButtonClick(Point position, MouseButtons button)
        {
            StopLastCursorTimer();

            MouseButton btn = button switch
            {
                MouseButtons.Right => MouseButton.Right,
                MouseButtons.Middle => MouseButton.Middle,
                MouseButtons.XButton1 => MouseButton.XButton1,
                MouseButtons.XButton2 => MouseButton.XButton2,
                _ => MouseButton.Left
            };

            var automationElement = AutomationService.HighlightMouseClickedElement();
            var controlType = ControlType.Unknown;

            try
            {
                if (automationElement != null)
                    controlType = automationElement.ControlType;
            }
            catch (Exception) { }

            if (controlType == ControlType.Unknown || AppConfig.Config.UndefinedControlTypes.Contains(controlType.ToString()))
                FlowConfig.UserActionList.Add(new UserAction(position, btn));
            else
                FlowConfig.UserActionList.Add(new UserAction(position, btn, controlType.ToString(),
                automationElement?.Name));

            FlowConfig.UserActionList[^1].ActionNumber = FlowConfig.UserActionList.Count;
        }

        private void RegisterMouseDoubleClick()
        {
            if (FlowConfig.UserActionList.Count == 0)
                return;

            FlowConfig.UserActionList[^1].DoubleClick = true;
        }

        private void RegisterMouseWheel(Point position, int delta)
        {
            FlowConfig.UserActionList.Add(new UserAction(position, MouseButton.Middle, delta));
            FlowConfig.UserActionList[^1].ActionNumber = FlowConfig.UserActionList.Count;
        }

        private void StopLastCursorTimer()
        {
            if (FlowConfig.UserActionList.Count == 0)
                return;

            FlowConfig.UserActionList[^1].InternalStopwatch.Stop();
            FlowConfig.UserActionList[^1].MilisecondsToNextAction = FlowConfig.UserActionList[^1].InternalStopwatch.ElapsedMilliseconds;
        }
    }
}
