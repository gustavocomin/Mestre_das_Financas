using MF.Domain.Commons.ClassesBase;
using MF.Domain.Commons.Consumirdores.Models;
using MF.Domain.Commons.Empresas.Models;
using MF.Domain.Commons.ModalidadePagto.CondPagtos.Models;
using MF.Domain.Commons.ModalidadePagto.FormaPagtos.Models;

namespace MF.Domain.ControleMensal.Despesas.Models
{
    public class DespesaView : IdBaseDtAlt
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

        public FormaPagtoView FormaPagto { get; set; }
        public CondPagtoView CondPagto { get; set; }
        public ConsumidorView Consumidor { get; set; }
        public EmpresaView? Empresa { get; set; }

        public DespesaView()
        {
        }

        public DespesaView(Despesa despesa)
        {
            if (despesa == null)
                return;

            Id = despesa.Id;
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
            FormaPagto = new FormaPagtoView(despesa.FormaPagto);
            CondPagto = new CondPagtoView(despesa.CondPagto);
            Consumidor = new ConsumidorView(despesa.Consumidor);
            Empresa = despesa.Empresa == null ? null : new EmpresaView(despesa.Empresa);
        }

        public List<DespesaView> ListDespesaView(List<Despesa> despesas)
        {
            List<DespesaView> list = new();

            if (!despesas.Any())
                return list;

            despesas.ForEach(x =>
            {
                list.Add(new DespesaView(x));
            });

            return list;
        }
    }
}