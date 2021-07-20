using MemorySteps.Core.Models;

namespace MemorySteps.Core.Models
{
    public class CurrentlyProcessingAction
    {
        public UserAction PreviousAction { get; set; }
        public UserAction CurrentAction { get; set; }
        public bool CharactersPressed { get; set; }
        public long FirstCharTime { get; set; }
    }

}
