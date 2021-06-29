using MemoryStepsCore.Services;


namespace MemoryStepsCore.Models
{
    public interface IMemoryMainForm : IMemoryForm
    {
        IMemoryProcessingForm CreateProcessingForm(IMemoryMainForm main, CursorExecutorService cursorExecutor, long totalDuration);
        void CloseProcessingForm();
        void OnRegisterComplete();
        void DisplayMessage(string message, string caption = "");
    }
}
