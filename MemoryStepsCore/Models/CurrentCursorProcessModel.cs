using MemoryStepsCore.Models;

namespace MemoryStepsCore.Models
{
    public class CurrentCursorProcessModel
    {
        public CursorEntity PrevCursor { get; set; }
        public CursorEntity CurrentCursor { get; set; }
        public bool CharactersPressed { get; set; }
        public long FirstCharTime { get; set; }

        public CurrentCursorProcessModel() 
        {
        }
    }

}
