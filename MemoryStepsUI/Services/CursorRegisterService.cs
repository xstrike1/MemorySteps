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
        public CursorRegisterService() 
        {
            TestConfig = new TestConfigEntity();
        }

        public void RegisterMouseButtonClick(Point position, MouseButtons button)
        {
            StopLastCursorTimer();

            MouseButton btn = MouseButton.Left;
            if (button == MouseButtons.Right)
                btn = MouseButton.Right;
            if (button == MouseButtons.Middle)
                btn = MouseButton.Middle;
            var automationElement = AutomationService.HighlightMouseClickedElement();
            var controlType = ControlType.Unknown;

            try
            {
                if(automationElement != null)
                    controlType = automationElement.ControlType;
            }
            catch (PropertyNotSupportedException)
            {

            }

            if (controlType == ControlType.Unknown || AppConfig.UndefinedControlTypes.Contains(controlType.ToString()))
                TestConfig.CursorList.Add(new CursorEntity(position, btn, AppConfig.Undefined, AppConfig.Undefined));
            else
                TestConfig.CursorList.Add(new CursorEntity(position, btn, controlType.ToString(),
                automationElement.Name));
          
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
