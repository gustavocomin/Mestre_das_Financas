using MF.Domain.Commons.Consumirdores;
using MF.Repository.Commons;
using MF.Repository.Configurations.Db;

namespace MF.Repository.Data.Commons.Consumirdores
{
    public class RepConsumidor : Rep<Consumidor>, IRepConsumidor
    {
        public RepConsumidor(DataContext contexto) : base(contexto)
        {
        }
    }
}