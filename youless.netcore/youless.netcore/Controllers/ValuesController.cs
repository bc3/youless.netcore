using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using youless.core;
using youless.core.connector;

namespace youless.netcore.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private YoulessConnector _connector = new YoulessConnector("192.168.0.137");


        // GET api/values
        [HttpGet]
        public async Task<Status> Get()
        {

            return await _connector.GetStatus();
        }
    }
}
