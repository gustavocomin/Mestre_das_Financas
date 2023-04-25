namespace MF.Domain.ControleMensal.Mercado.Compras.Itens.Models
{
    public class ItemCompraDto
    {
        public int CodigoCompra { get; set; }
        public int SequencialItem { get; set; }
        public string Descricao { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}