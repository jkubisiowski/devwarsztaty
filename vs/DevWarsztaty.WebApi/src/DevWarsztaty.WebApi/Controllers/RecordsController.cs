using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevWarsztaty.Messages.Commands;
using DevWarsztaty.WebApi.Storage;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;

namespace DevWarsztaty.WebApi.Controllers
{
    [Route("records")]
    public class RecordsController : Controller
    {
        private readonly IBusClient _busClient;
        private readonly IStorage _storage;

        public RecordsController(IBusClient busClient, IStorage storage)
        {
            _busClient = busClient;
            _storage = storage;
        }

        [HttpGet]
        public  IActionResult Get()
        {
            return Ok(_storage.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateRecord command)
        {
            await _busClient.PublishAsync(command);
            return StatusCode(202);
        }
    }
}
