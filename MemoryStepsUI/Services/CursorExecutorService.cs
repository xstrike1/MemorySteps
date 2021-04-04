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
        public event Action<bool> ExecutionCompleted;
        public event Action<long> StepCompleted;

        private CursorRegisterService _cursorRegister;

        private CursorExecutorService() { }

        public CursorExecutorService(CursorRegisterService cursorRegister) 
        {
            _cursorRegister = cursorRegister;
        }


        public long GetTotalDuration() 
        {
            if (_cursorRegister == null || _cursorRegister.CursorList.Count == 0) return 0;

            long duration = 0;
            foreach (var cursor in _cursorRegister.CursorList) 
            {
                duration += cursor.Ticks;
            }

            return duration;
        }

        public void Execute(Form form)  //need to add cancellation token
        {
            if (_cursorRegister == null || _cursorRegister.CursorList.Count == 0)
            {
                ExecutionCompleted?.Invoke(true);
                return;
            }
            for (int i = 0; i < _cursorRegister.CursorList.Count; i++) 
            {
                Dictionary<long, char> lastCursorDictionary = i == 0 ? 
                    new Dictionary<long, char>() : 
                    _cursorRegister.CursorList[i - 1].PressedCharacters;

                ExecuteCursor(_cursorRegister.CursorList[i], lastCursorDictionary);
            }

            ExecutionCompleted?.Invoke(true);

            form.Show();
            return;
        }

        private void ExecuteCursor(CursorEntity cursor, Dictionary<long, char> pressedCharacters) 
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            while (timer.ElapsedTicks < cursor.Ticks) 
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

            StepCompleted?.Invoke(cursor.Ticks);
            timer.Stop();
        }
    }
}
