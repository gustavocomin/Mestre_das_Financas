using MF.Domain.ControleMensal.Rendas;
using MF.Repository.Commons;
using MF.Repository.Configurations.Db;

namespace MF.Repository.Data.ControleMensal.Rendas
{
    public class RepRenda : Rep<Renda>, IRepRenda
    {
        public RepRenda(DataContext contexto) : base(contexto)
        {
        }
    }
}