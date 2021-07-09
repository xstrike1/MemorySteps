﻿using MemorySteps.Core.Services;


namespace MemorySteps.Core.Models
{
    public interface IMemoryMainForm : IMemoryForm
    {
        IMemoryProcessingForm ShowProcessingFormOnExecute(IMemoryMainForm main, CursorExecutorService cursorExecutor, long totalDuration);
        void CloseProcessingForm();
        void OnRegisterComplete();
        void DisplayMessage(string message, string caption = "");
    }
}
