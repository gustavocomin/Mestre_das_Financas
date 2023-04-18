using MF.Domain.Commons;

namespace MF.Domain.Commons.Usuarios
{
    public class UsuarioLogin : Usuario
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}