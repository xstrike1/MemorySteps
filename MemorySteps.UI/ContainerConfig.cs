using Autofac;
using MemorySteps.Core.Interfaces;
using MemorySteps.Core.Models;
using MemorySteps.Core.Services;

namespace MemorySteps.UI
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            ContainerBuilder builder = new();
            builder.RegisterType<MainWindow>().As<IMemoryMainWindow>().SingleInstance();
            builder.RegisterType<FlowRegisterService>().As<IFlowRegisterService>().SingleInstance();
            builder.RegisterType<MouseEventHandlers>().As<IMouseEventHandlers>().SingleInstance();
            builder.RegisterType<FlowExecutorService>().As<IFlowExecutorService>().SingleInstance();
            builder.RegisterType<Flow>().As<IFlow>().SingleInstance();

            return builder.Build();
        }
    }
}
