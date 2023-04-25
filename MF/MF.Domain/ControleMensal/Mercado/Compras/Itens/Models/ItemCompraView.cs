using MF.Domain.Commons.ClassesBase;
using MF.Domain.ControleMensal.Mercado.Compras.Itens.Desconto.Models;
using MF.Domain.ControleMensal.Mercado.Compras.Models;

namespace MF.Domain.ControleMensal.Mercado.Compras.Itens.Models
{
    public class ItemCompraView : IdBaseDtAlt
    {
        public int CodigoCompra { get; set; }
        public int SequencialItem { get; set; }
        public string Descricao { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotalItem { get; set; }
        public int? CodigoDesconto { get; set; }

        public DescontoItemView DescontoItem { get; set; }
        public CompraView Compra { get; set; }

        public ItemCompraView()
        {
        }

        public ItemCompraView(ItemCompra itemCompra)
        {
            CodigoCompra = itemCompra.CodigoCompra;
            SequencialItem = itemCompra.SequencialItem;
            Descricao = itemCompra.Descricao;
            Quantidade = itemCompra.Quantidade;
            ValorUnitario = itemCompra.ValorUnitario;
            ValorTotalItem = itemCompra.ValorTotalItem;
            CodigoDesconto = itemCompra.CodigoDesconto;
            DescontoItem = new DescontoItemView(itemCompra.DescontoItem);
            Compra = new CompraView(itemCompra.Compra);
        }

        public List<ItemCompraView> ListItemCompraView(List<ItemCompra> itemCompras)
        {
            List<ItemCompraView> list = new();
            itemCompras.ForEach(itemCompra =>
            {
                list.Add(new ItemCompraView(itemCompra));
            });
            return list;
        }
    }
}