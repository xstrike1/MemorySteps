using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms.VisualStyles;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Input;
using FlaUI.UIA3;

namespace MemoryStepsUI.Services
{
    public static  class AutomationService
    {
        public static readonly string UndefinedType = "Undefined";
        private static readonly AutomationBase AutBase = new UIA3Automation();
        public static AutomationElement CurrentHoveredElement;
        private static Timer Timer;

        public static void StartTimer()
        {
            Timer = new Timer()
            {
                Interval = 40,
                Enabled = true
            };
            Timer.Elapsed += TimerOnTick;
            Timer.Start();
        }

        public static void StopTimer()
        {
            Timer.Elapsed -= TimerOnTick;
        }

        public static AutomationElement HighlightMouseClickedElement()
        {
            ElementHighlighter.HighlightElement(CurrentHoveredElement);
            return CurrentHoveredElement;
        }

        public static AutomationElement GetHoveredElement()
        {
            var screenPos = Mouse.Position;
            return AutBase.FromPoint(screenPos);
        }

        private static void TimerOnTick(object sender, EventArgs e)
        {
            var screenPos = Mouse.Position;
            CurrentHoveredElement = AutBase.FromPoint(screenPos);

        }
    }
}
