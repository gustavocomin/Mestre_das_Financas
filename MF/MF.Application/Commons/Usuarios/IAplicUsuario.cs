using MF.Domain.Commons.Usuarios.Models;

namespace MF.Application.Commons.Usuarios
{
    public interface IAplicUsuario
    {
        void AlterarSenha(string email, string senha, string senhaRepetida);
        void Delete(int id);
        void Delete(List<int> ids);
        List<UsuarioView> FindAll();
        UsuarioView FindById(int id);
        UsuarioView Insert(UsuarioCadastroDto dto);
        void RecuperarSenha(string? login, string? email);
        UsuarioView Update(int id, UsuarioCadastroDto dto);
    }
}