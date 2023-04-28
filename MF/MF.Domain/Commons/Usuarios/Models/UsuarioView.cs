using MF.Domain.Commons.ClassesBase;

namespace MF.Domain.Commons.Usuarios.Models
{
    public class UsuarioView : IdBaseDtAlt
    {
        public string Login { get; set; }
        public string Email { get; set; }

        public UsuarioView()
        {
        }

        public UsuarioView(Usuario usuario)
        {
            Id = usuario.Id;
            Login = usuario.Login;
            Email = usuario.Email;
        }

        public List<UsuarioView> ListUsuarioView(List<Usuario> usuarios)
        {
            List<UsuarioView> list = new();
            usuarios.ForEach(con =>
            {
                list.Add(new UsuarioView(con));
            });
            return list;
        }
    }
}