namespace MF.Domain.ControleMensal.Mercado.Compras.Models
{
    public class CompraDto
    {
        public string Descricao { get; set; }
        public DateTime DataCompra { get; set; }
        public decimal ValorTributos { get; set; }
        public string? COO { get; set; }
        public string? CCF { get; set; }

        public int? CodigoFormaPagto { get; set; }
        public int? CodigoCondPagto { get; set; }
        public int? CodigoEmpresa { get; set; }
    }
}