using MF.Domain.Commons.ClassesBase;
using MF.Domain.ControleMensal.Mercado.Compras.Itens.Desconto.Models;

namespace MF.Domain.ControleMensal.Mercado.Compras.Itens.Desconto
{
    public class DescontoItem : IdBase
    {
        public int CodigoItemCompra { get; set; }

        public decimal ValorDesconto { get; set; }
        public ItemCompra ItemCompra { get; set; }

        public DescontoItem()
        {
        }

        public DescontoItem(DescontoItemDto descontoItem)
        {
            CodigoItemCompra = descontoItem.CodigoItemCompra;
            ValorDesconto = descontoItem.ValorDesconto;
        }
    }
}