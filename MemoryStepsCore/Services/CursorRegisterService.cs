﻿using MemorySteps.Core.Models;
using Microsoft.Test.Input;
using System.Drawing;
using System.Windows.Forms;
using FlaUI.Core.Definitions;
using FlaUI.Core.Exceptions;
using MemorySteps.Core.Config;
using System;
using Gma.System.MouseKeyHook;
using System.Collections.Generic;

namespace MemorySteps.Core.Services
{
    public class CursorRegisterService
    {
        public TestConfigEntity TestConfig;
        public Action OnRegisterFinish;
        private IKeyboardMouseEvents _globalHook;
        private MouseEventHandlers _mouseEventHandlers;
        public CursorRegisterService() 
        {
            TestConfig = new TestConfigEntity();
            _mouseEventHandlers = new MouseEventHandlers()
            {
                MouseClickEventHandler = GlobalHook_MouseClick,
                MouseDoubleClickEventHandler = GlobalHook_MouseDoubleClick,
                MouseDragStartedEventHandler = GlobalHook_MouseDragStarted,
                MouseDragFinishedEventHandler = GlobalHook_MouseDragFinished
            };

            if (!AppConfig.Config.DisableMouseScrollCapture)
                _mouseEventHandlers.MouseWheelEventHandler = GlobalHook_MouseWheel;
        }

        public void StartCursorRegister() 
        {
            TestConfig.CursorList = new List<CursorEntity>();
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

        bool mouseDragStarted = false;

        private void GlobalHook_MouseDragStarted(object sender, MouseEventArgs e) 
        {
            mouseDragStarted = true;
            RegisterMouseButtonClick(e.Location, e.Button);
        }
        private void GlobalHook_MouseDragFinished(object sender, MouseEventArgs e) 
        {
            mouseDragStarted = false;
            TestConfig.CursorList[^1].DragPosition = e.Location;
        }

        private void RegisterKeyPress(char key)
        {
            if (TestConfig.CursorList.Count < 1)
                return;

            var currentCursor = TestConfig.CursorList[^1];
            currentCursor.PressedCharacters.Add(currentCursor.Time.ElapsedMilliseconds, key);
        }

        private void RegisterMouseButtonClick(Point position, MouseButtons button)
        {
            StopLastCursorTimer();

            var btn = button switch
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
                if(automationElement != null)
                    controlType = automationElement.ControlType;
            }
            catch (PropertyNotSupportedException) { }

            if (controlType == ControlType.Unknown || AppConfig.Config.UndefinedControlTypes.Contains(controlType.ToString()))
                TestConfig.CursorList.Add(new CursorEntity(position, btn));
            else
                TestConfig.CursorList.Add(new CursorEntity(position, btn, controlType.ToString(),
                automationElement?.Name));

            TestConfig.CursorList[^1].CursorNumber = TestConfig.CursorList.Count;
        }

        private void RegisterMouseDoubleClick() 
        {
            if (TestConfig.CursorList.Count == 0)
                return;

            TestConfig.CursorList[^1].DoubleClick = true;
        }

        private void RegisterMouseWheel(Point position, int delta)
        {
            TestConfig.CursorList.Add(new CursorEntity(position, MouseButton.Middle, delta));
            TestConfig.CursorList[^1].CursorNumber = TestConfig.CursorList.Count;
        }

        private void StopLastCursorTimer()
        {
            if (TestConfig.CursorList.Count == 0)
                return;

            TestConfig.CursorList[^1].Time.Stop();
            TestConfig.CursorList[^1].MilisecondsToNextCursor = TestConfig.CursorList[^1].Time.ElapsedMilliseconds;
        }
    }
}
