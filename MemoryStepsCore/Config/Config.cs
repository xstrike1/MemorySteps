using System.Collections.Generic;

namespace MemoryStepsCore.Models
{
    public class Config 
    {
        public char KeyBind { get; private set; } = '`';
        public int MaxActionDelay { get; private set; } = 5000;
        public List<string> UndefinedControlTypes { get; } = new();
        public string Undefined = "UNDEFINED";
    }
}
