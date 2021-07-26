using ElectronNET.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemorySteps.ElectronUI
{
    public static class MemoryBrowserWindow 
    {
        private static BrowserWindow _mainWindow;
        private static bool _mainWindowIsMaximized = false;
        private static (int x, int y) _windowDefaultSize = (1400, 1050);

        public static BrowserWindow MainWindow { get => _mainWindow; }

        internal static void MaximizeWindow() 
        {

            //TODO: check size on button click
            if (_mainWindowIsMaximized)
            {
                MainWindow.SetSize(_windowDefaultSize.x, _windowDefaultSize.y);
            }
            else
            {
                MainWindow.Maximize();
            }

            _mainWindowIsMaximized = !_mainWindowIsMaximized;
        } 

        internal static async void CreateWindow()
        {
            var windowOptions = new ElectronNET.API.Entities.BrowserWindowOptions
            {
                Width = _windowDefaultSize.x,
                Height = _windowDefaultSize.y,
                MinWidth = 800,
                MinHeight = 600,
                Frame = false,
                AutoHideMenuBar = true
            };

            _mainWindow = await Electron.WindowManager.CreateWindowAsync(windowOptions);
            _mainWindow.OnClosed += () => { Electron.App.Quit(); };
        }
    }
}
