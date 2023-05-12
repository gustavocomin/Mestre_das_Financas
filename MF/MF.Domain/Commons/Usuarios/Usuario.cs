using MF.Domain.Commons.ClassesBase;
using MF.Domain.Commons.Consumirdores.Models;
using MF.Domain.Commons.Usuarios.Models;

namespace MF.Domain.Commons.Usuarios
{
    public class Usuario : IdBaseDtAlt
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Usuario()
        {
        }

        public Usuario(UsuarioCadastroDto usuario)
        {
            Login = usuario.Login.Trim();
            Email = usuario.Email.Trim();
            Senha = usuario.Senha.Trim();
            Nome = usuario.Nome.Trim();
        }

        public Usuario AtualizaUsuario(Usuario usuario, UsuarioCadastroDto usuarioDto)
        {
            usuario.Login = usuarioDto.Login.Trim();
            usuario.Email = usuarioDto.Email.Trim();
            usuario.Nome = usuarioDto.Nome.Trim();
            usuario.Senha = usuarioDto.Senha.Trim();

            return usuario;
        }

        public ConsumidorDto CriaConsumidor(UsuarioCadastroDto dto)
        {
            ConsumidorDto consumidor = new()
            {
                Nome = dto.Nome.Trim(),
                Email = dto.Email.Trim()
            };

            return consumidor;
        }
    }
}