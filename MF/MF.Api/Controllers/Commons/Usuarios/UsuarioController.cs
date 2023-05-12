using MF.Application.Commons.Usuarios;
using MF.Domain.Commons.Usuarios.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MF.Api.Controllers.Commons.Usuarios
{
    [Route("/v1/Usuario")]
    [ApiController]
    [AllowAnonymous]
    public class UsuarioController : ControllerBase
    {
        private readonly IAplicUsuario _aplicUsuario;

        public UsuarioController(IAplicUsuario aplicUsuario)
        {
            _aplicUsuario = aplicUsuario;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] UsuarioCadastroDto dto)
        {
            try
            {
                UsuarioView view = _aplicUsuario.Insert(dto);
                return Created("", view);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UsuarioCadastroDto dto)
        {
            try
            {
                UsuarioView view = _aplicUsuario.Update(id, dto);
                return Ok(view);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPost]
        [Route("RecuperarSenha/{login}/{email}")]
        public async Task<IActionResult> RecuperarSenha(string login, string email)
        {
            try
            {
                _aplicUsuario.RecuperarSenha(login, email);
                return Ok();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPut]
        [Route("AlterarSenha")]
        public async Task<IActionResult> AlterarSenha(AlterarSenhaDto dto)
        {
            try
            {
                _aplicUsuario.AlterarSenha(dto.Email, dto.Senha, dto.SenhaRepetida);
                return Ok();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
