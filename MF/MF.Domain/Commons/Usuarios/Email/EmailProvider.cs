using MF.Domain.Commons.ClassesBase;

namespace MF.Domain.Commons.Usuarios.Email
{
    public class EmailProvider : IdBaseDtAlt
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public string UsuarioAlteracao { get; set; }
    }
}