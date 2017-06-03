using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevWarsztaty.Messages.Commands;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;

namespace DevWarsztaty.WebApi.Controllers
{
    [Route("records")]
    public class RecordsController : Controller
    {
        private readonly IBusClient _busClient;

        public RecordsController(IBusClient busClient)
        {
            _busClient = busClient;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateRecord command)
        {
            await _busClient.PublishAsync(command);
            return StatusCode(202);
        }
    }
}
