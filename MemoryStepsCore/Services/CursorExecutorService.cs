using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using FlaUI.Core.Exceptions;
using Microsoft.Test.Input;
using MemoryStepsCore.Models;
using MemoryStepsCore.Config;
using System.Drawing;

namespace MemoryStepsCore.Services
{
    public class CursorExecutorService
    {
        public event Action<long, long, CursorEntity, CursorEntity> StepCompleted;
        private readonly CursorRegisterService _cursorRegister;

        public CursorExecutorService(CursorRegisterService cursorRegister) 
        {
            _cursorRegister = cursorRegister;
        }

        public long GetTotalDuration()
        {
            return _cursorRegister.TestConfig.CursorList.Sum(cursor => cursor.MilisecondsToNextCursor);
        }

        public TimeSpan Execute(IMemoryMainForm parentForm)  
        {
            if (_cursorRegister == null || _cursorRegister.TestConfig.CursorList.Count == 0)
            {
                return new TimeSpan(0);
            }

            Stopwatch time = new();
            time.Start();
            var totalDuration = GetTotalDuration();
            var autoclickerForm = parentForm.CreateProcessingForm(parentForm, this, totalDuration);
            autoclickerForm.Show();
            Application.DoEvents(); 

            InternalExecute(parentForm, autoclickerForm);
            time.Stop();

            return time.Elapsed;
        }

        private void InternalExecute(IMemoryMainForm parentForm, IMemoryProcessingForm autoclickerForm) 
        {
            ExecuteMouseClick(_cursorRegister.TestConfig.CursorList[0]);
            long lastCursorTimer = 0;
            for (int i = 1; i < _cursorRegister.TestConfig.CursorList.Count; i++)
            {
                var previousCursorEntity = _cursorRegister.TestConfig.CursorList[i - 1];
                var currentCursor = _cursorRegister.TestConfig.CursorList[i];
                var nextCursor = i < _cursorRegister.TestConfig.CursorList.Count - 1 ? _cursorRegister.TestConfig.CursorList[i + 1] : null;
                StepCompleted?.Invoke(lastCursorTimer, previousCursorEntity.MilisecondsToNextCursor, currentCursor, nextCursor);

                try
                {
                    lastCursorTimer = ExecuteCursor(_cursorRegister.TestConfig.CursorList[i], previousCursorEntity, autoclickerForm);
                }
                catch 
                {
                    parentForm.CloseProcessingForm();
                    break;
                }

                if (autoclickerForm.CancelHasBeenRequested)
                    break;
            }

            parentForm.CloseProcessingForm();
        }

        private static long ExecuteCursor(CursorEntity cursor, CursorEntity previousCursor,  IMemoryProcessingForm form) 
        {
            var timer = new Stopwatch();
            timer.Start();
            long firstCharacterMs = 0;
            var charactersPressed = false;

            if (previousCursor.PressedCharacters.Count > 0)
                firstCharacterMs = previousCursor.PressedCharacters.FirstOrDefault().Key;
            else
                charactersPressed = true;

            while (timer.ElapsedMilliseconds < previousCursor.MilisecondsToNextCursor)
            {

                if (form.CancelHasBeenRequested)
                    return 0;

                if (charactersPressed || firstCharacterMs == 0 ||
                    timer.ElapsedMilliseconds <= firstCharacterMs) 
                    continue;

                foreach (var value in previousCursor.PressedCharacters.Values)
                    SendKeys.Send(value.ToString());

                charactersPressed = true;
            }
            timer.Stop();

            ExecuteMouseClick(cursor);
            return timer.ElapsedMilliseconds;
        }

        private static void ExecuteMouseClick(CursorEntity cursor)
        {
            Mouse.MoveTo(cursor.Position);

            var st = new Stopwatch();
            st.Start();
            var controlIsGood =  IsMouseOverControl(cursor, st);

            if (!controlIsGood)
                throw new ApplicationException("Control not found!");

            if (cursor.DragPosition != Point.Empty)
            {
                Mouse.DragTo(cursor.ButtonPressed, cursor.DragPosition);
                return;
            }

            if (cursor.MouseWheelDelta != 0)
            {
                Mouse.Scroll(cursor.MouseWheelDelta / SystemInformation.MouseWheelScrollDelta);
                return;
            }

            if (cursor.DoubleClick)
                Mouse.DoubleClick(cursor.ButtonPressed);
            else
                Mouse.Click(cursor.ButtonPressed);
        }

        private static bool IsMouseOverControl(CursorEntity cursor, Stopwatch st)
        {
            if (cursor.ControlType == AppConfig.Config.Undefined) return true;

            while (true)
            {
                var r = AutomationService.GetHoveredElement();
                if (st.ElapsedMilliseconds > AppConfig.Config.MaxActionDelay) return false;
                try
                {
                    if (cursor.ControlType == "" || r == null ||
                        r.ControlType.ToString() != cursor.ControlType)
                        continue;

                    if (AppConfig.Config.CheckControlName && r.Name != cursor.ControlName)
                        continue;

                    ElementHighlighter.HighlightElement(r, Color.BlueViolet);
                    return true;
                }
                catch(PropertyNotSupportedException)
                {
                    Thread.Sleep(50);
                }
            }
        }
    }
}
