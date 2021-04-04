using MemoryStepsUI.Models;
using MemoryStepsUI.UI;
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
        public event Action<long> StepCompleted;
        private CursorRegisterService _cursorRegister;
        private CursorExecutorService() { }

        public CursorExecutorService(CursorRegisterService cursorRegister) 
        {
            _cursorRegister = cursorRegister;
        }

        public long GetTotalDuration() 
        {
            long duration = 0;
            foreach (var cursor in _cursorRegister.CursorList) 
            {
                duration += cursor.Ticks;
            }

            return duration;
        }

        public void Execute(ConfigUIForm parentForm)  //need to add cancellation token
        {
            if (_cursorRegister == null || _cursorRegister.CursorList.Count == 0)
            {
                return;
            }

            long totalDuration = GetTotalDuration();
            AutoclickerForm autoclickerForm = new AutoclickerForm(parentForm, this, totalDuration);
            autoclickerForm.Show();
            Application.DoEvents(); 

            InternalExecute(parentForm, autoclickerForm);
        }

        private void InternalExecute(ConfigUIForm parentForm, AutoclickerForm autoclickerForm) 
        {
            for (int i = 0; i < _cursorRegister.CursorList.Count; i++)
            {
                Dictionary<long, char> lastCursorDictionary = i == 0 ?
                    new Dictionary<long, char>() :
                    _cursorRegister.CursorList[i - 1].PressedCharacters;

                ExecuteCursor(_cursorRegister.CursorList[i], lastCursorDictionary, autoclickerForm);

                if (autoclickerForm.CancelHasBeenRequested)
                    break;
            }

            autoclickerForm.Hide();
            parentForm.Show();
            return;
        }

        private void ExecuteCursor(CursorEntity cursor, Dictionary<long, char> pressedCharacters, IFormWithCancelRequest form) 
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            while (timer.ElapsedTicks < cursor.Ticks) 
            {
                timer.Stop();

                if (form.CancelHasBeenRequested)
                    return;

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
