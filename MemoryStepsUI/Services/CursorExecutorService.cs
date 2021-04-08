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
                duration += cursor.Miliseconds;
            }

            return duration;
        }

        public void Execute(ConfigUIForm parentForm)  
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
            long firstCharacterMs = 0;
            bool charactersPressed = false;

            if (pressedCharacters.Count > 0)
                firstCharacterMs = pressedCharacters.FirstOrDefault().Key;
            else
                charactersPressed = true;


            while (timer.ElapsedMilliseconds < cursor.Miliseconds)
            {
                if (form.CancelHasBeenRequested)
                    return;

                if (!charactersPressed && firstCharacterMs != 0 && timer.ElapsedMilliseconds > firstCharacterMs)
                {
                    foreach (var value in pressedCharacters.Values)
                        SendKeys.Send(value.ToString());

                    charactersPressed = true;
                }

            }
            timer.Stop();

            Mouse.MoveTo(cursor.Position);
            Mouse.Click(cursor.ButtonPressed);

            StepCompleted?.Invoke(cursor.Miliseconds);
        }
    }
}
