namespace MemoryStepsUI.UI
{
    internal interface IFormWithCancelRequest
    {
        bool CancelHasBeenRequested { get; set; }
    }
}