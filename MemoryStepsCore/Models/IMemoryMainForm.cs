using MemoryStepsUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryStepsCore.Models
{
    public interface IMemoryMainForm : IMemoryForm
    {
        IMemoryProcessingForm CreateProcessingForm(IMemoryMainForm main, CursorExecutorService cursorExecutor, long totalDuration);
        void CloseProcessingForm();
    }
}
