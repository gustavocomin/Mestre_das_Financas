namespace MF.Domain.Commons.ModalidadePagto.CondPagtos.Parcs.Models
{
    public class CondPagtoParcsDto
    {
        public int CodigoOrigem { get; set; }
        public OrigemCongPagtoParc Origem { get; set; }
        public int CodigoCondPagto { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal QuantParc { get; set; }
    }
}