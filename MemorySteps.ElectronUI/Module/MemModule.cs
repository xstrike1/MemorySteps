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
            //SingleInstance for now
            builder.RegisterType<FlowRegisterService>().As<IFlowRegisterService>().SingleInstance();
            builder.RegisterType<MouseEventHandlers>().As<IMouseEventHandlers>().SingleInstance();
            builder.RegisterType<FlowExecutorService>().As<IFlowExecutorService>().SingleInstance();
            builder.RegisterType<Flow>().As<IFlow>().SingleInstance();
        }
    }
}
