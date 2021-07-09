using System;
using System.Drawing;
using System.Threading.Tasks;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Exceptions;


namespace MemorySteps.Core.Services
{
    public static class ElementHighlighter
    {
        public static void HighlightElement(AutomationElement automationElement, Color? highlightColor = null)
        {
            if(automationElement == null)
                return;

            try
            {
                Task.Run(() =>
                {
                    return automationElement.DrawHighlight(false, highlightColor ?? Color.Blue, TimeSpan.FromMilliseconds(500));
                });
            }
            catch (PropertyNotSupportedException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
