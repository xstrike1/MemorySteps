using Autofac;
using MemorySteps.Core.Interfaces;
using MemorySteps.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

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
            _flowRegisterService.OnFlowEnd += _flowRegisterService_OnFlowEnd;

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

        private void _flowRegisterService_OnFlowEnd()
        {
            MemoryBrowserWindow.MainWindow.Show();
            _flowRegisterService.OnFlowEnd -= _flowRegisterService_OnFlowEnd;
        }
    }
}
