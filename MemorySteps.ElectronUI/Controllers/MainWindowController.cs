using ElectronNET.API;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemorySteps.ElectronUI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainWindowController : ControllerBase
    {
        private readonly ILogger<MainWindowController> _logger;
      
        public MainWindowController(ILogger<MainWindowController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("close")]
        [Route("mainwindow/close")]
        public void Get()
        {
           MemoryBrowserWindow.MainWindow.Close();
        }

        [HttpGet]
        [Route("max")]
        [Route("mainwindow/max")]
        public void MaximizeWindow()
        {
            MemoryBrowserWindow.MaximizeWindow();
        }

        [HttpGet]
        [Route("min")]
        [Route("mainwindow/min")]
        public void MinimizeWindow()
        {
            MemoryBrowserWindow.MainWindow.Minimize();
        }
    }
}
