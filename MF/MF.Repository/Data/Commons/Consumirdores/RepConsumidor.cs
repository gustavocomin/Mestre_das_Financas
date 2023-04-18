using MF.Domain.Commons.Consumirdores;
using MF.Repository.Commons;
using MF.Repository.Configurations.Db;

namespace MF.Repository.Data.Commons.Consumirdores
{
    public class RepConsumidor : Rep<Consumidor>
    {
        public RepConsumidor(Contexto contexto) : base(contexto)
        {
        }
    }
}