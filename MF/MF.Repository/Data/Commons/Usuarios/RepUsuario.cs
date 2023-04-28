using MF.Domain.Commons.Usuarios;
using MF.Repository.Commons;
using MF.Repository.Configurations.Db;

namespace MF.Repository.Data.Commons.Usuarios
{
    public class RepUsuario : Rep<Usuario>, IRepUsuario
    {
        public RepUsuario(DataContext contexto) : base(contexto)
        {
        }
    }
}