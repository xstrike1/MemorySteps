using MemoryStepsUI.Models;
using Microsoft.Test.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryStepsUI.Services
{
    public class CursorExecutorService
    {
        private CursorRegisterService _cursorRegister;

        private CursorExecutorService() { }

        public CursorExecutorService(CursorRegisterService cursorRegister) 
        {
            _cursorRegister = cursorRegister;
        }

        public void Execute() 
        {
            if (_cursorRegister == null || _cursorRegister.CursorList.Count == 0)
                return;

            for (int i = 0; i < _cursorRegister.CursorList.Count; i++) 
            {
                Dictionary<long, char> lastCursorDictionary = i == 0 ? 
                    new Dictionary<long, char>() : 
                    _cursorRegister.CursorList[i - 1].PressedCharacters;

                ExecuteCursor(_cursorRegister.CursorList[i], lastCursorDictionary);
            }
        }

        private void ExecuteCursor(CursorEntity cursor, Dictionary<long, char> pressedCharacters) 
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            while (timer.ElapsedTicks < cursor.Time.ElapsedTicks) 
            {
                timer.Stop();

                if (pressedCharacters.ContainsKey(timer.ElapsedTicks)) 
                {
                    SendKeys.Send(pressedCharacters[timer.ElapsedTicks].ToString());
                }

                timer.Start();
            }
            Mouse.MoveTo(cursor.Position);
            Mouse.Click(cursor.ButtonPressed);

            timer.Stop();
        }
    }
}
