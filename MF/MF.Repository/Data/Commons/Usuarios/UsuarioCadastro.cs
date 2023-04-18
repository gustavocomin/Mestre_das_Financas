using MF.Domain.Commons;

namespace MF.Domain.Commons.Usuarios
{
    public class UsuarioCadastro : Usuario
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}