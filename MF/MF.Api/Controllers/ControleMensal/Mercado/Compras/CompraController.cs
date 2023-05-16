using MF.Application.ControleMensal.Mercado.Compras;
using MF.Domain.ControleMensal.Mercado.Compras.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MF.Api.Controllers.ControleMensal.Mercado.Compras
{
    [ApiController]
    [Route("api/v1/Compra")]
    [AllowAnonymous]
    public class CompraController : ControllerBase
    {
        private readonly IAplicCompra _aplicCompra;

        public CompraController(IAplicCompra aplicCompra)
        {
            _aplicCompra = aplicCompra;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] CompraDto dto)
        {
            try
            {
                CompraView view = _aplicCompra.Insert(dto);
                return Created("", view);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPost]
        [Route("ImportarNCFE")]
        public async Task<IActionResult> ImportarNFCE([FromBody] string urlNfce)
        {
            try
            {
                CompraView view = await _aplicCompra.ImportarNFCEAsync(urlNfce);
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
                List<CompraView> views = _aplicCompra.FindAll();
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
                CompraView view = _aplicCompra.FindById(id);
                return Ok(view);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] CompraDto dto)
        {
            try
            {
                CompraView view = _aplicCompra.Update(id, dto);
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
                _aplicCompra.Delete(id);
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
                _aplicCompra.Delete(ids);
                return Ok();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
