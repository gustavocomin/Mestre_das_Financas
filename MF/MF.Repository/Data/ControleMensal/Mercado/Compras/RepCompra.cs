using MF.Domain.ControleMensal.Mercado.Compras;
using MF.Repository.Commons;
using MF.Repository.Configurations.Db;

namespace MF.Repository.Data.ControleMensal.Mercado.Compras
{
    public class RepCompra : Rep<Compra>, IRepCompra
    {
        public RepCompra(DataContext contexto) : base(contexto)
        {
        }
    }
}