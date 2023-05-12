using MF.Application.Commons.ModalidadePagto.CondPagtos;
using MF.Domain.Commons.ModalidadePagto.CondPagtos.Models;
using Microsoft.AspNetCore.Mvc;

namespace MF.Api.Controllers.Commons.ModalidadePagto.CondPagtos
{
    [ApiController]
    [Route("api/v1/CondPagto")]
    public class CondPagtoController : ControllerBase
    {
        private readonly IAplicCondPagto _aplicCondPagto;

        public CondPagtoController(IAplicCondPagto aplicCondPagto)
        {
            _aplicCondPagto = aplicCondPagto;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] CondPagtoDto dto)
        {
            try
            {
                CondPagtoView view = _aplicCondPagto.Insert(dto);
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
                List<CondPagtoView> views = _aplicCondPagto.FindAll();
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
                CondPagtoView view = _aplicCondPagto.FindById(id);
                return Ok(view);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] CondPagtoDto dto)
        {
            try
            {
                CondPagtoView view = _aplicCondPagto.Update(id, dto);
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
                _aplicCondPagto.Delete(id);
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
                _aplicCondPagto.Delete(ids);
                return Ok();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
