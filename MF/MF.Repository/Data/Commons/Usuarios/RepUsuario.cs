using MF.Domain.Commons.Usuarios;
using MF.Repository.Commons;
using MF.Repository.Configurations.Db;

namespace MF.Repository.Data.Commons.Usuarios
{
    public class RepUsuario : Rep<Usuario>, IRepUsuario
    {
        private readonly DataContext _contexto;

        public RepUsuario(DataContext contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public Usuario FindByLoginOrEmail(string email, string login)
        {
            if (string.IsNullOrEmpty(login) && string.IsNullOrEmpty(email))
                throw new Exception("Email e login inválidos! Por favor, forneça uma das informações.");

            Usuario usuario = _contexto.Set<Usuario>().FirstOrDefault(x => x.Login.Trim().ToUpper() == login.Trim().ToUpper() ||
                                                                           x.Email.Trim().ToUpper() == email.Trim().ToUpper())
                            ?? throw new Exception("Usuário não encontrado!");

            return usuario;
        }
    }
}
