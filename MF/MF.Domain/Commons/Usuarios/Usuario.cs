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
            Login = usuario.Login;
            Email = usuario.Email;
            Senha = usuario.Senha;
            Nome = usuario.Nome;
        }

        public Usuario AtualizaUsuario(Usuario usuario, UsuarioCadastroDto usuarioDto)
        {
            usuario.Login = usuarioDto.Login;
            usuario.Email = usuarioDto.Email;
            usuario.Email = usuarioDto.Email;

            return usuario;
        }

        public ConsumidorDto CriaConsumidor(UsuarioCadastroDto dto)
        {
            ConsumidorDto consumidor = new()
            {
                Nome = dto.Nome,
                Email = dto.Email
            };

            return consumidor;
        }
    }
}