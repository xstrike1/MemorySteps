using Autofac;
using MemorySteps.Core.Interfaces;
using MemorySteps.Core.Models;
using MemorySteps.Core.Services;

namespace MemorySteps.ElectronUI
{
    public class MemModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FlowRegisterService>().As<IFlowRegisterService>();
            builder.RegisterType<MouseEventHandlers>().As<IMouseEventHandlers>();
            builder.RegisterType<FlowExecutorService>().As<IFlowExecutorService>();
            builder.RegisterType<Flow>().As<IFlow>();
        }
    }
}
