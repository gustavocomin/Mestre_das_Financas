using MF.Domain.Commons.ClassesBase;

namespace MF.Domain.ControleMensal.Mercado.Compras
{
    public class ItemCompra : IdBaseDtAlt
    {
        public ItemCompra()
        {
            ValorTotalItem = ValorUnitario * Quantidade;
        }

        public int CodigoCompra { get; set; }
        public int SequencialItem { get; set; }
        public string Descricao { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorTotalItem { get; private set; }
        public int CodigoDesconto { get; set; }

        public DescontoItem Desconto { get; set; }
    }
}