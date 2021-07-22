using MemorySteps.Core.Models;

namespace MemorySteps.Core.Interfaces
{
    public interface IMemoryProcessingWindow : IMemoryWindow
    {
        bool CancelHasBeenRequested { get; set; }
        public void Executor_StepCompleted(long currentDuration, UserAction currentCursor, UserAction nextCursor);
        public void SendKey(string value);
    }
}
