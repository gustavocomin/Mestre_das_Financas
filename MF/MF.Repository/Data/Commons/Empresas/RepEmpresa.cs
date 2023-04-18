using MF.Domain.Commons.Empresas;
using MF.Repository.Commons;
using MF.Repository.Configurations.Db;

namespace MF.Repository.Data.Commons.Empresas
{
    public class RepEmpresa : Rep<Empresa>
    {
        public RepEmpresa(Contexto contexto) : base(contexto)
        {
        }
    }
}