using MF.Domain.Commons.ClassesBase;
using MF.Domain.ControleMensal.Mercado.Compras.Itens.Desconto;

namespace MF.Domain.ControleMensal.Mercado.Compras.Itens
{
    public class ItemCompra : IdBaseDtAlt
    {
        public int CodigoCompra { get; set; }
        public int SequencialItem { get; set; }
        public string Descricao { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotalItem { get; set; }

        public int? CodigoDesconto { get; set; }
        public DescontoItem DescontoItem { get; set; }

        public Compra Compra { get; set; }

        public void CalculaValorTotalItem()
        {
            ValorTotalItem = ValorUnitario * Quantidade;
        }
    }
}