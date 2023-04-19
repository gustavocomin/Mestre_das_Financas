using MF.Domain.Commons.Consumirdores;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MF.Api.Controllers.Commons.Consumirdores
{
    [Route("/v1/Consumidor")]
    [ApiController]
    [Authorize]
    public class ConsumidorController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post()
        {

            return Created("", new Consumidor());
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {

            return Ok(new Consumidor());
        }

        [HttpPut]
        [Route("")]
        public async Task<IActionResult> Put()
        {

            return Ok(new Consumidor());
        }

        [HttpDelete]
        [Route("")]
        public async Task<IActionResult> Delete()
        {

            return Ok(new Consumidor());
        }
    }
}
