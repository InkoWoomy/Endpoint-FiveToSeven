using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Endpoint_FiveToSeven.Services.Mini7A;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Endpoint_FiveToSeven.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Mini7AController : Controller
    {
        private readonly IReverseItAlphanumericService _logger;

        public Mini7AController(IReverseItAlphanumericService logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("Mini7-ReverseIt(Alphanumeric)/{input}")]
        public string ReverseItA (string input)
        {
            return _logger.ReverseItA(input);
        }
    }
}