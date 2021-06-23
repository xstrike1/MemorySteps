using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Exceptions;
using FlaUI.Core.Overlay;
using FlaUI.Core.WindowsAPI;

namespace MemoryStepsUI.Services
{
    public static class ElementHighlighter
    {
        public static void HighlightElement(AutomationElement automationElement)
        {
            if(automationElement == null)
                return;

            try
            {
                Task.Run(() =>
                {
                    return automationElement.DrawHighlight(false, Color.Blue, TimeSpan.FromSeconds(1));
                });
            }
            catch (PropertyNotSupportedException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
