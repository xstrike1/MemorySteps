using System;
using System.Timers;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Input;
using FlaUI.UIA3;

namespace MemorySteps.Core.Services
{
    public static class AutomationService
    {
        private static readonly AutomationBase AutBase = new UIA3Automation();
        private static AutomationElement CurrentHoveredElement;
        private static Timer Timer;

        public static void StartTimer()
        {
            Timer = new Timer()
            {
                Interval = 10,
                Enabled = true
            };
            Timer.Elapsed += UpdateHoveredElement;
            Timer.Start();
        }

        public static void StopTimer()
        {
            Timer.Elapsed -= UpdateHoveredElement;
        }

        public static AutomationElement HighlightMouseClickedElement()
        {
            ElementHighlighterService.HighlightElement(CurrentHoveredElement);
            return CurrentHoveredElement;
        }

        public static AutomationElement GetHoveredElement()
        {
            System.Drawing.Point screenPos = Mouse.Position;
            return AutBase.FromPoint(screenPos);
        }

        private static void UpdateHoveredElement(object sender, EventArgs e)
        {
            System.Drawing.Point screenPos = Mouse.Position;
            CurrentHoveredElement = AutBase.FromPoint(screenPos);
        }
    }
}
