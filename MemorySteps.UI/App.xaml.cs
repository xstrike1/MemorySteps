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
            using (ILifetimeScope scope = container.BeginLifetimeScope())
            {
                IFlowRegisterService flowRegister = scope.Resolve<IFlowRegisterService>();
                flowRegister.FlowConfig.UserActionList = new System.Collections.Generic.List<Core.Models.UserAction>();

                XamlDisplay.Init();
                base.OnStartup(e);
            }
        }
    }
}
