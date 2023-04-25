namespace MF.Domain.ControleMensal.Despesas.Models
{
    public class DespesaDto
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public TipoDespesa TipoDespesa { get; set; }
        public DateTime DataDespesa { get; set; }
        public bool Mensal { get; set; }
        public DateTime? DataInicial { get; set; }
        public DateTime? DataFinal { get; set; }

        public int? CodigoEmpresa { get; set; }
        public int CodigoConsumidor { get; set; }
        public int CodigoFormaPagto { get; set; }
        public int CodigoCondPagto { get; set; }
    }
}