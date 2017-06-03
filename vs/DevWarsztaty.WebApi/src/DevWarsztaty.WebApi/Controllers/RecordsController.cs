using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevWarsztaty.Messages.Commands;
using Microsoft.AspNetCore.Mvc;

namespace DevWarsztaty.WebApi.Controllers
{
    [Route("records")]
    public class RecordsController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateRecord command)
        {
            return StatusCode(202);
        }
    }
}
