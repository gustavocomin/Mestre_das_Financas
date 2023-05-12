using MF.Domain.Commons.Usuarios.Email;
using MF.Repository.Commons;
using MF.Repository.Configurations.Db;

namespace MF.Repository.Data.Commons.Usuarios.Email
{
    public class RepEmailProvider : Rep<EmailProvider>, IRepEmailProvider
    {
        public RepEmailProvider(DataContext contexto) : base(contexto)
        {
        }
    }
}