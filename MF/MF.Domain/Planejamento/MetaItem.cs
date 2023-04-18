using MF.Domain.Commons.ClassesBase;

namespace MF.Domain.Planejamento
{
    public class MetaItem : IdBaseDtAlt
    {
        public string Descricao { get; set; }
        public decimal ValorCompra { get; set; }
        public string LinkCompra { get; set; }
        public decimal ReservaCompra { get; set; }
        private decimal DiferencaCompraReserva { get { return ReservaCompra - ValorCompra; } }
        public DateTime? DataExpectativaAquisicao { get; set; }
        public decimal ValorGuardarMes { get; set; }
        public StatusMetaEItem Status { get; set; }
    }

    public enum StatusMetaEItem
    {
        Ativo = 0,
        Inativo = 1,
        Parado = 2,
        Finalizado = 3
    }
}