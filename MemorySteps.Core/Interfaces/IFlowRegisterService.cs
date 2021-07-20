namespace MemorySteps.Core.Interfaces
{
    public interface IFlowRegisterService
    {
        IFlow FlowConfig { get; set; }

        void StartFlowRegister();
    }
}