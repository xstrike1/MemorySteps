using System.Collections.Generic;

namespace MemorySteps.Core.Models
{
    public class ConfigModel 
    {
        /// <summary>
        /// Keybind to end action register and execution
        /// </summary>
        public char KeyBind { get; private set; } = '`';

        /// <summary>
        /// Max delay to find the correct control, in miliseconds
        /// </summary>
        public int MaxActionDelay { get; private set; } = 5000;

        /// <summary>
        /// Control types that can cause a runtime error in certain applications
        /// </summary>
        public List<string> UndefinedControlTypes { get; } = new()
        {
            "Pane",
            "DataItem"
        };
        /// <summary>
        /// If false, at execution, check only the control type of the hovered control
        /// </summary>
        public bool CheckControlName { get; set; } = true;
        public bool DisableMouseScrollCapture { get; set; } = true;
        public string Undefined = "UNDEFINED";
        
    }
}
