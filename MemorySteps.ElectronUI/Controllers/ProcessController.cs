using Autofac;
using MemorySteps.Core.Interfaces;
using MemorySteps.Core.Services;
using Microsoft.AspNetCore.Http;
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
        [Route("get")]
        [Route("process/get")]
        public void Get() 
        {
            //RIP
            // AutomationService.StartTimer();
            //_flowRegisterService.StartFlowRegister();
        }
    }
}
