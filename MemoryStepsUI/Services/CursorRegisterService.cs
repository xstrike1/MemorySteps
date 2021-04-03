using MemoryStepsUI.Models;
using Microsoft.Test.Input;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryStepsUI.Services
{
    public class CursorRegisterService
    {
        private List<CursorEntity> _cursorList = new List<CursorEntity>();
        public List<CursorEntity> CursorList => _cursorList;

        public void ResetList() 
        {
            _cursorList = new List<CursorEntity>();
        }

        public void LoadList(List<CursorEntity> cursorList) 
        {
            _cursorList = cursorList.ToList();
        }

        public void RegisterMouseButtonClick(Point position, MouseButtons button) 
        {
            StopLastCursorTimewatch();

            MouseButton btn = MouseButton.Left;
            if (button == MouseButtons.Right)
                btn = MouseButton.Right;
            if (button == MouseButtons.Middle)
                btn = MouseButton.Middle;

            _cursorList.Add(new CursorEntity(position, btn));
        }

        public void RegisterKeyPress(char key) 
        {
            if (_cursorList.Count <1)
                return;

            var currentCursor = _cursorList[_cursorList.Count - 1];
            currentCursor.PressedCharacters.Add(currentCursor.Time.ElapsedTicks, key);
        }

        public void StopLastCursorTimewatch() 
        {
            if (_cursorList.Count == 0)
                return;

            _cursorList[_cursorList.Count - 1].Time.Stop();
        }
    }
}
