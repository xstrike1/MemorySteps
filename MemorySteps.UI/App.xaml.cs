using Autofac;
using MemorySteps.Core.Interfaces;
using ShowMeTheXAML;
using System.Windows;

namespace MemorySteps.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            IContainer container = ContainerConfig.Configure();
            IMemoryMainWindow viewModel = container.Resolve<IMemoryMainWindow>();
            ILifetimeScope scope = container.BeginLifetimeScope();
            IFlowRegisterService flowRegister = container.Resolve<IFlowRegisterService>();
            IFlowExecutorService flowExecutor = container.Resolve<IFlowExecutorService>();

            MainWindow window = new(scope, flowRegister, flowExecutor) { DataContext = viewModel };
            window.Show();
        }
    }
}
