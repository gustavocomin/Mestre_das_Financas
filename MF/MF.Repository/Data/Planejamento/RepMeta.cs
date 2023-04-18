using MF.Domain.Planejamento;
using MF.Repository.Commons;
using MF.Repository.Configurations.Db;

namespace MF.Repository.Data.Planejamento
{
    public class RepMeta : Rep<Meta>
    {
        public RepMeta(Contexto contexto) : base(contexto)
        {
        }
    }
}