namespace MF.Domain.Planejamento.Itens.Models
{
    public class MetaItemDto
    {
        public string Descricao { get; set; }
        public decimal ValorCompra { get; set; }
        public string? LinkCompra { get; set; }
        public decimal ValorReservaCompra { get; set; }
        public DateTime DataExpectativaAquisicao { get; set; }
        public StatusMetaEItem Status { get; set; }
        public int CodigoMeta { get; set; }
    }
}