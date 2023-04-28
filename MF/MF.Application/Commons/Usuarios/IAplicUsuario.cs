using MF.Domain.Commons.Usuarios.Models;

namespace MF.Application.Commons.Usuarios
{
    public interface IAplicUsuario
    {
        void Delete(int id);
        void Delete(List<int> ids);
        List<UsuarioView> FindAll();
        UsuarioView FindById(int id);
        UsuarioView Insert(UsuarioCadastroDto dto);
        UsuarioView Update(int id, UsuarioCadastroDto dto);
    }
}