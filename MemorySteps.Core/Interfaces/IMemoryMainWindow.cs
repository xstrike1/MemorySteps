using MemorySteps.Core.Services;


namespace MemorySteps.Core.Interfaces
{
    public interface IMemoryMainWindow : IMemoryWindow
    {
        IMemoryProcessingWindow ShowProcessingFormOnExecute(IMemoryMainWindow main, FlowExecutorService cursorExecutor, long totalDuration);
        void CloseProcessingForm();
        void OnRegisterComplete();
        void DisplayMessage(string message, string caption = "");
    }
}
