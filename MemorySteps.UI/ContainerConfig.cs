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
            builder.RegisterType<MainWindow>().As<IMemoryMainWindow>();
            builder.RegisterType<FlowRegisterService>().As<IFlowRegisterService>();
            builder.RegisterType<MouseEventHandlers>().As<IMouseEventHandlers>();
            builder.RegisterType<FlowExecutorService>().As<IFlowExecutorService>();
            builder.RegisterType<Flow>().As<IFlow>();

            return builder.Build();
        }
    }
}
