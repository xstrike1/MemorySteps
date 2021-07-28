using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using ElectronNET.API;
using Autofac.Extensions.DependencyInjection;

namespace MemorySteps.ElectronUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseElectron(args);
                    webBuilder.UseEnvironment("Developement"); 
                    webBuilder.UseStartup<Startup>();
                });
    }
}
