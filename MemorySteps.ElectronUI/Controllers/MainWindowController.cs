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
    [Route("api/[controller]/[action]")]
    public class MainWindowController : Controller
    {
        private readonly ILogger<MainWindowController> _logger;

        public MainWindowController(ILogger<MainWindowController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> MainWindow(long id) 
        {
            await Task.Run( () =>Startup.MainWindow.Close());

            return Ok("");
        }


        [HttpGet]
        [ActionName("close")]
        public async Task<IActionResult> MainWindow()
        {
            await Task.Run(() => Startup.MainWindow.Maximize());

            return Ok("");
        }

        //[HttpPost]
        //public void MaximizeMainWindow()
        //{
        //    Startup.MainWindow.Maximize();
        //}

        //[HttpPost]
        //public void MinimzeMainWindow()
        //{
        //    Startup.MainWindow.Minimize();
        //}

        //[HttpPost]
        //public void Post()
        //{
        //    Startup.MainWindow.Minimize();
        //}
    }
}
