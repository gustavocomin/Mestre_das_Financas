using MF.Application.Commons.ModalidadePagto.CondPagtos.Parcs;
using MF.Domain.Commons.ModalidadePagto.CondPagtos.Parcs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MF.Api.Controllers.Commons.ModalidadePagto.CondPagtos.Parcs
{
    [ApiController]
    [Route("api/v1/CondPagtoParcs")]
    public class CondPagtoParcsController : ControllerBase
    {
        private readonly IAplicCondPagtoParcs _aplicCondPagtoParcs;

        public CondPagtoParcsController(IAplicCondPagtoParcs aplicCondPagtoParcs)
        {
            _aplicCondPagtoParcs = aplicCondPagtoParcs;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] CondPagtoParcsDto dto)
        {
            try
            {
                List<CondPagtoParcsView> views = _aplicCondPagtoParcs.Insert(dto);
                return Created("", views);
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
                List<CondPagtoParcsView> views = _aplicCondPagtoParcs.FindAll();
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
                List<CondPagtoParcsView> views = _aplicCondPagtoParcs.FindById(id);
                return Ok(views);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] CondPagtoParcsDto dto)
        {
            try
            {
                List<CondPagtoParcsView> views = _aplicCondPagtoParcs.Update(id, dto);
                return Ok(views);
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
                _aplicCondPagtoParcs.Delete(id);
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
                _aplicCondPagtoParcs.Delete(ids);
                return Ok();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
