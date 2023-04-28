using MF.Domain.Commons.Usuarios.Models;

namespace MF.Domain.Commons.Usuarios.Validacoes
{
    public interface IValidacoesUsuario
    {
        void ValidaEmailUnico(UsuarioCadastroDto dto);
        void ValidaLoginUnico(UsuarioCadastroDto dto);
    }
}