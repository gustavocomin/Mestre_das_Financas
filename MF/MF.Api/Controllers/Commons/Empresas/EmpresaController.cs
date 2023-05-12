using MF.Application.Commons.Empresas;
using MF.Domain.Commons.Empresas.Models;
using Microsoft.AspNetCore.Mvc;

namespace MF.Api.Controllers.Commons.Empresas
{
    [ApiController]
    [Route("/v1/Empresa")]
    public class EmpresaController : ControllerBase
    {
        private readonly IAplicEmpresa _aplicEmpresa;

        public EmpresaController(IAplicEmpresa aplicEmpresa)
        {
            _aplicEmpresa = aplicEmpresa;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] EmpresaDto dto)
        {
            try
            {
                EmpresaView view = _aplicEmpresa.Insert(dto);
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
                List<EmpresaView> views = _aplicEmpresa.FindAll();
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
                EmpresaView view = _aplicEmpresa.FindById(id);
                return Ok(view);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] EmpresaDto dto)
        {
            try
            {
                EmpresaView view = _aplicEmpresa.Update(id, dto);
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
                _aplicEmpresa.Delete(id);
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
                _aplicEmpresa.Delete(ids);
                return Ok();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
