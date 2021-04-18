using MemoryStepsUI.Models;
using MemoryStepsUI.UI;
using Microsoft.Test.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryStepsUI.Services
{
    public class CursorExecutorService
    {
        public event Action<long> StepCompleted;
        private readonly CursorRegisterService _cursorRegister;
        private CursorExecutorService() { }

        public CursorExecutorService(CursorRegisterService cursorRegister) 
        {
            _cursorRegister = cursorRegister;
        }

        public long GetTotalDuration()
        {
            return _cursorRegister.TestConfig.CursorList.Sum(cursor => cursor.Milliseconds);
        }

        public TimeSpan Execute(MainForm parentForm)  
        {
            if (_cursorRegister == null || _cursorRegister.TestConfig.CursorList.Count == 0)
            {
                return new TimeSpan(0);
            }

            Stopwatch time = new();
            time.Start();
            var totalDuration = GetTotalDuration();
            var autoclickerForm = new AutoclickerForm(parentForm, this, totalDuration) {TopMost = true};
            autoclickerForm.Show();
            Application.DoEvents(); 

            InternalExecute(parentForm, autoclickerForm);
            time.Stop();

            return time.Elapsed;
        }

        private void InternalExecute(MainForm parentForm, AutoclickerForm autoclickerForm) 
        {
           ExecuteMouseClick(_cursorRegister.TestConfig.CursorList[0]);

            for (int i = 1; i < _cursorRegister.TestConfig.CursorList.Count; i++)
            {
                var previousCursorEntity = _cursorRegister.TestConfig.CursorList[i - 1];
                ExecuteCursor(_cursorRegister.TestConfig.CursorList[i], previousCursorEntity, autoclickerForm);

                if (autoclickerForm.CancelHasBeenRequested)
                    break;
            }

            autoclickerForm.Hide();
            parentForm.Show();
        }

        private void ExecuteCursor(CursorEntity cursor, CursorEntity previousCursor,  IFormWithCancelRequest form) 
        {
            var timer = new Stopwatch();
            timer.Start();
            long firstCharacterMs = 0;
            var charactersPressed = false;

            if (previousCursor.PressedCharacters.Count > 0)
                firstCharacterMs = previousCursor.PressedCharacters.FirstOrDefault().Key;
            else
                charactersPressed = true;

            while (timer.ElapsedMilliseconds < previousCursor.Milliseconds)
            {
                if (form.CancelHasBeenRequested)
                    return;

                if (charactersPressed || firstCharacterMs == 0 ||
                    timer.ElapsedMilliseconds <= firstCharacterMs) 
                    continue;

                foreach (var value in previousCursor.PressedCharacters.Values)
                    SendKeys.Send(value.ToString());

                charactersPressed = true;
            }
            timer.Stop();

            ExecuteMouseClick(cursor);
            StepCompleted?.Invoke(previousCursor.Milliseconds);
        }

        private void ExecuteMouseClick(CursorEntity cursor)
        {
            Mouse.MoveTo(cursor.Position);
            Mouse.Click(cursor.ButtonPressed);
        }

    }
}
