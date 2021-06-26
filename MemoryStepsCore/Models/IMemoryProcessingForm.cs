namespace MemoryStepsCore.Models
{
    public interface IMemoryProcessingForm : IMemoryForm
    {
        bool CancelHasBeenRequested { get; set; }
    }
}
