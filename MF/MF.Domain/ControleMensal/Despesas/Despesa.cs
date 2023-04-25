using MF.Domain.Commons.ClassesBase;
using MF.Domain.Commons.Consumirdores;
using MF.Domain.Commons.Empresas;
using MF.Domain.Commons.ModalidadePagto.CondPagtos;
using MF.Domain.Commons.ModalidadePagto.FormaPagtos;
using MF.Domain.ControleMensal.Despesas.Models;
using System.ComponentModel;

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

        public Despesa()
        {
        }

        public Despesa(DespesaDto despesa)
        {
            Descricao = despesa.Descricao;
            Valor = despesa.Valor;
            TipoDespesa = despesa.TipoDespesa;
            DataDespesa = despesa.DataDespesa;
            Mensal = despesa.Mensal;
            DataInicial = despesa.DataInicial;
            DataFinal = despesa.DataFinal;
            CodigoEmpresa = despesa.CodigoEmpresa;
            CodigoConsumidor = despesa.CodigoConsumidor;
            CodigoFormaPagto = despesa.CodigoFormaPagto;
            CodigoCondPagto = despesa.CodigoCondPagto;
        }
    }

    public enum TipoDespesa
    {
        [Description("Moradia")]
        Moradia = 0,
        [Description("Transporte")]
        Transporte = 1,
        [Description("Entretenimento")]
        Entretenimento = 2,
        [Description("Investimentos")]
        Investimentos = 3,
        [Description("Animais")]
        Animais = 4,
        [Description("Pessoais")]
        Pessoais = 5,
        [Description("Mercado")]
        Mercado = 6,
        [Description("Outros")]
        Outros = 7,
    }
}