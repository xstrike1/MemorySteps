using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ElectronNET.API;


namespace MemorySteps.ElectronUI
{
    public class Startup
    {
        private static BrowserWindow mainWindow;
        public IConfiguration Configuration { get; }
        public static BrowserWindow MainWindow { get => mainWindow; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                //app.UseHsts();
            }

            //app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");

                endpoints.MapFallbackToFile("index.html");
            });
            
            if (HybridSupport.IsElectronActive) 
            {
                CreateWindow();
            }
        }

        private static async void CreateWindow() 
        {
            var windowOptions = new ElectronNET.API.Entities.BrowserWindowOptions 
            {
                Width = 1400,
                Height = 1050,
                MinWidth = 800,
                MinHeight = 600,
                // Frame = false,
                // AutoHideMenuBar = true
            };

            mainWindow = await Electron.WindowManager.CreateWindowAsync(windowOptions);
            mainWindow.OnClosed += () => { Electron.App.Quit(); };
        }
    }
}
