using MF.Application.ControleMensal.Mercado.Compras.Itens;
using MF.Domain.ControleMensal.Mercado.Compras.Itens.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MF.Api.Controllers.ControleMensal.Mercado.Itens
{
    [ApiController]
    [Route("api/v1/ItemCompra")]
    [AllowAnonymous]
    public class ItemCompraController : ControllerBase
    {
        private readonly IAplicItemCompra _aplicItemCompra;

        public ItemCompraController(IAplicItemCompra aplicItemCompra)
        {
            _aplicItemCompra = aplicItemCompra;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] ItemCompraDto dto)
        {
            try
            {
                ItemCompraView view = _aplicItemCompra.Insert(dto);
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
                List<ItemCompraView> views = _aplicItemCompra.FindAll();
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
                ItemCompraView view = _aplicItemCompra.FindById(id);
                return Ok(view);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ItemCompraDto dto)
        {
            try
            {
                ItemCompraView view = _aplicItemCompra.Update(id, dto);
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
                _aplicItemCompra.Delete(id);
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
                _aplicItemCompra.Delete(ids);
                return Ok();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
