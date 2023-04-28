using MF.Application.Commons.Consumirdores;
using MF.Domain.Commons.Consumirdores.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MF.Api.Controllers.Commons.Consumirdores
{
    [Route("/v1/Consumidor")]
    [ApiController]
    [AllowAnonymous]
    public class ConsumidorController : ControllerBase
    {
        private readonly IAplicConsumidor _aplicConsumidor;

        public ConsumidorController(IAplicConsumidor aplicConsumidor)
        {
            _aplicConsumidor = aplicConsumidor;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] ConsumidorDto dto)
        {
            try
            {
                ConsumidorView view = _aplicConsumidor.Insert(dto);
                return Created("", view);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<ConsumidorView> views = _aplicConsumidor.FindAll();
                return Ok(views);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                ConsumidorView view = _aplicConsumidor.FindById(id);
                return Ok(view);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ConsumidorDto dto)
        {
            try
            {
                ConsumidorView view = _aplicConsumidor.Update(id, dto);
                return Ok(view);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteById(int id)
        {
            try
            {
                _aplicConsumidor.Delete(id);
                return Ok();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteByIds")]
        public async Task<IActionResult> DeleteByIds([FromBody] List<int> ids)
        {
            try
            {
                _aplicConsumidor.Delete(ids);
                return Ok();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
