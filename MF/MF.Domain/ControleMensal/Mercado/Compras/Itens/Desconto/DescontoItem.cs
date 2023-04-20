using MF.Domain.Commons.ClassesBase;

namespace MF.Domain.ControleMensal.Mercado.Compras.Itens.Desconto
{
    public class DescontoItem : IdBase
    {
        public int CodigoItemCompra { get; set; }

        public decimal ValorDesconto { get; set; }
        public ItemCompra ItemCompra { get; set; }
    }
}