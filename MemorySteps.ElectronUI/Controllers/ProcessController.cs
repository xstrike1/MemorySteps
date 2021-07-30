using Autofac;
using MemorySteps.Core.Interfaces;
using MemorySteps.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading;

namespace MemorySteps.ElectronUI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProcessController : ControllerBase
    {
        private readonly ILogger<ProcessController> _logger;
        private ILifetimeScope _scope;
        private IFlowRegisterService _flowRegisterService;
        private IFlowExecutorService _flowExecutor;

        public ProcessController(ILogger<ProcessController> logger, ILifetimeScope scope, IFlowRegisterService flowRegisterService, IFlowExecutorService flowExecutor)
        {
            _logger = logger;
            _scope = scope;
            _flowRegisterService = flowRegisterService;
            _flowExecutor = flowExecutor;
        }

        [HttpGet]
        [Route("startregister")]
        [Route("process/startregister")]
        public void StartRegister() 
        {
            MemoryBrowserWindow.MainWindow.Hide();
            _flowRegisterService.FlowRegisterEnded += OnFlowRegisterEnded;

            Thread flowThread = new (StartFlowRegister);
            flowThread.Start();
        }

        [HttpGet]
        [Route("stopregister")]
        [Route("process/stopregister")]
        public void StopRegister()
        {
            // MemoryBrowserWindow.MainWindow.Hide(); //will be added later with show
            Thread flowThread = new(_flowExecutor.Execute);
            flowThread.Start();
        }

        private void StartFlowRegister() 
        {
            AutomationService.StartTimer();
            _flowRegisterService.StartFlowRegister();
        }

        private void OnFlowRegisterEnded()
        {
            MemoryBrowserWindow.MainWindow.Show();
            _flowRegisterService.FlowRegisterEnded -= OnFlowRegisterEnded;
        }
    }
}
