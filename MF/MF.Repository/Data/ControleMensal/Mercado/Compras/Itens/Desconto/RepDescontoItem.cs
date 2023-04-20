using MF.Domain.ControleMensal.Mercado.Compras.Itens.Desconto;
using MF.Repository.Commons;
using MF.Repository.Configurations.Db;

namespace MF.Repository.Data.ControleMensal.Mercado.Compras.Itens.Desconto
{
    public class RepDescontoItem : Rep<DescontoItem>, IRepDescontoItem
    {
        public RepDescontoItem(DataContext contexto) : base(contexto)
        {
        }
    }
}