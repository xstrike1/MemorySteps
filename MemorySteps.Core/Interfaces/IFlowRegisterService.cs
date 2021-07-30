using MemorySteps.Core.Models;
using System;

namespace MemorySteps.Core.Interfaces
{
    public interface IFlowRegisterService
    {
        event Action FlowRegisterEnded;
        IFlow FlowConfig { get; set; }
        void StartFlowRegister();
    }
}