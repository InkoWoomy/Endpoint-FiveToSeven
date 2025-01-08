using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Endpoint_FiveToSeven.Services.Mini6;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Endpoint_FiveToSeven.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Mini6Controller : Controller
    {
        private readonly IOddOrEvenService _logger;

        public Mini6Controller(IOddOrEvenService logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("Mini6-OddEven/{num}")]
        public string OddOrEven (string num)
        {
            return _logger.OddOrEven(num);
        }
    }
}