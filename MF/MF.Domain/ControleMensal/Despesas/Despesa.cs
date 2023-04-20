using MF.Domain.Commons.ClassesBase;
using MF.Domain.Commons.Consumirdores;
using MF.Domain.Commons.Empresas;
using MF.Domain.Commons.ModalidadePagto.CondPagtos;
using MF.Domain.Commons.ModalidadePagto.FormaPagtos;

namespace MF.Domain.ControleMensal.Despesas
{
    public class Despesa : IdBaseDtAlt
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

        public FormaPagto FormaPagto { get; set; }
        public CondPagto CondPagto { get; set; }
        public Consumidor Consumidor { get; set; }
        public Empresa? Empresa { get; set; }
    }

    public enum TipoDespesa
    {
        Moradia = 0,
        Transporte = 1,
        Entretenimento = 2,
        Investimentos = 3,
        Animais = 4,
        Pessoais = 5,
        Mercado = 6,
        Outros = 7,
    }
}