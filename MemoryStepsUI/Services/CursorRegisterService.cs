using MemoryStepsUI.Models;
using Microsoft.Test.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Definitions;
using FlaUI.Core.Exceptions;

namespace MemoryStepsUI.Services
{
    public class CursorRegisterService
    {
        public TestConfigEntity TestConfig;
        private int doubleClickTime = System.Windows.Forms.SystemInformation.DoubleClickTime;

        public CursorRegisterService() 
        {
            TestConfig = new TestConfigEntity();
        }

        public void RegisterMouseButtonClick(Point position, MouseButtons button, int clicks)
        {
            StopLastCursorTimer();

            var btn = button switch
            {
                MouseButtons.Right => MouseButton.Right,
                MouseButtons.Middle => MouseButton.Middle,
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

            if (controlType == ControlType.Unknown || AppConfig.UndefinedControlTypes.Contains(controlType.ToString()))
                TestConfig.CursorList.Add(new CursorEntity(position, btn, clicks));
            else
                TestConfig.CursorList.Add(new CursorEntity(position, btn, clicks, controlType.ToString(),
                automationElement?.Name));
          
        }

        public void RegisterKeyPress(char key)
        {
            if (TestConfig.CursorList.Count < 1)
                return;

            var currentCursor = TestConfig.CursorList[^1];
            currentCursor.PressedCharacters.Add(currentCursor.Time.ElapsedMilliseconds, key);
        }

        public void StopLastCursorTimer(bool unsubscribe = false)
        {
            if (TestConfig.CursorList.Count == 0)
                return;

            TestConfig.CursorList[^1].Time.Stop();
            TestConfig.CursorList[^1].Milliseconds = TestConfig.CursorList[^1].Time.ElapsedMilliseconds;
        }
    }
}
