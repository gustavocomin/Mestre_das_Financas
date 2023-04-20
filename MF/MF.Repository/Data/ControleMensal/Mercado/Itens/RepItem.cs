using MF.Domain.ControleMensal.Mercado.Itens;
using MF.Repository.Commons;
using MF.Repository.Configurations.Db;

namespace MF.Repository.Data.ControleMensal.Mercado.Itens
{
    public class RepItem : Rep<Item>, IRepItem
    {
        public RepItem(DataContext contexto) : base(contexto)
        {
        }
    }
}