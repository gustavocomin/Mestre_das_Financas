using MF.Domain.Commons.ClassesBase;

namespace MF.Domain.Commons.Usuarios
{
    public class Usuario : IdBaseDtAlt
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}