using MemoryStepsCore.Config;
using Microsoft.Test.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace MemoryStepsCore.Models
{
    public class CursorEntity
    {
        public int CursorNumber { get; set; }
        public long MilisecondsToNextCursor { get; set; }
        public Point Position { get; set; }
        public Point DragPosition { get; set; }
        [NonSerialized]
        public Stopwatch Time;
        public Dictionary<long, char> PressedCharacters { get; set; }
        public MouseButton ButtonPressed { get; set; }
        public int MouseWheelDelta { get; set; }
        public bool DoubleClick { get; set; }
        public string ControlType { get; set; } = AppConfig.Config.Undefined;
        public string ControlName { get; set; } = AppConfig.Config.Undefined;

        public CursorEntity() 
        {
            Time = new Stopwatch();
            Time.Start();
            PressedCharacters = new Dictionary<long, char>();
        }

        public CursorEntity(Point position) 
            : this()
        {
            Position = position;
        }

        public CursorEntity(Point position, MouseButton buttonPressed)
           : this(position)
        {
            ButtonPressed = buttonPressed;
        }

        public CursorEntity(Point position, MouseButton buttonPressed, int mouseWheelDelta)
        : this(position, buttonPressed)
        {
            MouseWheelDelta = mouseWheelDelta;
        }

        public CursorEntity(Point position, MouseButton buttonPressed , string controlType, string controlName)
            : this(position, buttonPressed)
        {
            ButtonPressed = buttonPressed;
            ControlType = controlType;
            ControlName = controlName;
        }
    }
}
