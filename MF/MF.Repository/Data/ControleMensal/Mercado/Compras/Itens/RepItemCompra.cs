using MF.Domain.ControleMensal.Mercado.Compras.Itens;
using MF.Repository.Commons;
using MF.Repository.Configurations.Db;

namespace MF.Repository.Data.ControleMensal.Mercado.Compras.Itens
{
    public class RepItemCompra : Rep<ItemCompra>
    {
        public RepItemCompra(Contexto contexto) : base(contexto)
        {
        }
    }
}