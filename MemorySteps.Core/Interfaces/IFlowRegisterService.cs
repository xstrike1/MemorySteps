using MemorySteps.Core.Models;
using System;

namespace MemorySteps.Core.Interfaces
{
    public interface IFlowRegisterService
    {
        event Action OnFlowEnd;
        IFlow FlowConfig { get; set; }
        void StartFlowRegister();
    }
}