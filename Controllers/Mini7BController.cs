using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Endpoint_FiveToSeven.Services.Mini7B;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Endpoint_FiveToSeven.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Mini7BController : Controller
    {
        private readonly IReverseItNumericService _logger;

        public Mini7BController(IReverseItNumericService logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("Mini7-ReverseIt(Numeric)/{input}")]
        public string ReverseItB (string input)
        {
            return _logger.ReverseItB(input);
        }
    }
}