using MemorySteps.Core.Config;
using Microsoft.Test.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace MemorySteps.Core.Models
{
    public class UserAction
    {
        public int ActionNumber { get; set; }
        public long MilisecondsToNextAction { get; set; }
        public Point Position { get; set; }
        public Point DragPosition { get; set; }
        [NonSerialized]
        private Stopwatch internalStopwatch;
        public Dictionary<long, char> PressedCharacters { get; set; }
        public MouseButton ButtonPressed { get; set; }
        public int MouseWheelDelta { get; set; }
        public bool DoubleClick { get; set; }
        public string ControlType { get; set; } = AppConfig.Config.Undefined;
        public string ControlName { get; set; } = AppConfig.Config.Undefined;
        public Stopwatch InternalStopwatch { get => internalStopwatch; set => internalStopwatch = value; }

        public UserAction()
        {
            InternalStopwatch = new Stopwatch();
            InternalStopwatch.Start();
            PressedCharacters = new Dictionary<long, char>();
        }

        public UserAction(Point position)
            : this()
        {
            Position = position;
        }

        public UserAction(Point position, MouseButton buttonPressed)
           : this(position)
        {
            ButtonPressed = buttonPressed;
        }

        public UserAction(Point position, MouseButton buttonPressed, int mouseWheelDelta)
        : this(position, buttonPressed)
        {
            MouseWheelDelta = mouseWheelDelta;
        }

        public UserAction(Point position, MouseButton buttonPressed , string controlType, string controlName)
            : this(position, buttonPressed)
        {
            ButtonPressed = buttonPressed;
            ControlType = controlType;
            ControlName = controlName;
        }
    }
}
