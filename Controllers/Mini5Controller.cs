using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Endpoint_FiveToSeven.Services.Mini5;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Endpoint_FiveToSeven.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Mini5Controller : Controller
    {
        private readonly IMadLibsService _logger;

        public Mini5Controller(IMadLibsService logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("Mini5-MadLibs/{verb1}/{verb2}/{verb3}/{place}/{personName}/{animal}/{adjective}/{clothingItem}/{noun1}/{noun2}")]
        public string MadLibs (string verb1, string verb2, string verb3, string place, string personName, string animal, string adjective, string clothingItem, string noun1, string noun2)
        {
            return _logger.MadLibs(verb1, verb2, verb3, place, personName, animal, adjective, clothingItem, noun1, noun2);
        }
    }
}