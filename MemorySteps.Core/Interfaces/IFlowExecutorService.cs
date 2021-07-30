using MemorySteps.Core.Models;
using MemorySteps.Core.Services;

namespace MemorySteps.Core.Interfaces
{
    public interface IFlowExecutorService
    {
        void Execute(/*IMemoryMainWindow parentForm*/);
        long GetTotalDuration();
    }
}