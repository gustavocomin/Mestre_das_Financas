using MF.Domain.ControleMensal.Despesas;
using MF.Repository.Commons;
using MF.Repository.Configurations.Db;

namespace MF.Repository.Data.ControleMensal.Despesas
{
    public class RepDespesa : Rep<Despesa>, IRepDespesa
    {
        public RepDespesa(DataContext contexto) : base(contexto)
        {
        }
    }
}