namespace MemoryStepsCore.Models
{
    public interface IMemoryProcessingForm : IMemoryForm
    {
        bool CancelHasBeenRequested { get; set; }
        public void Executor_StepCompleted(long currentDuration, CursorEntity currentCursor, CursorEntity nextCursor);
        public void SendKey(string value);
    }
}
