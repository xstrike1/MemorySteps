using MemoryStepsUI.Models;
using Microsoft.Test.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            StopLastCursorTimewatch();

            MouseButton btn = MouseButton.Left;
            if (button == MouseButtons.Right)
                btn = MouseButton.Right;
            if (button == MouseButtons.Middle)
                btn = MouseButton.Middle;

            TestConfig.CursorList.Add(new CursorEntity(position, btn));
        }

        public void RegisterKeyPress(char key)
        {
            if (TestConfig.CursorList.Count < 1)
                return;

            var currentCursor = TestConfig.CursorList[^1];
            currentCursor.PressedCharacters.Add(currentCursor.Time.ElapsedMilliseconds, key);
        }

        public void StopLastCursorTimewatch(bool unsubscribe = false)
        {
            if (TestConfig.CursorList.Count == 0)
                return;

            TestConfig.CursorList[^1].Time.Stop();
            TestConfig.CursorList[^1].Milliseconds = TestConfig.CursorList[^1].Time.ElapsedMilliseconds;
        
            //if (unsubscribe)
            //    TestConfig.CursorList[^1].Milliseconds += 1500;
        }
    }
}
