using MF.Domain.Consumirdores;
using MF.Domain.Empresas;

namespace MF.Domain.Despesas
{
    public class Despesa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public TipoDespesa TipoDespesa { get; set; }
        public DateTime DataDespesa { get; set; }
        public decimal Desconto { get; set; }
        public int CodigoEmpresa { get; set; }
        public int CodigoConsumidor { get; set; }

        public virtual Consumidor Consumidor { get; set; }
        public virtual Empresa Empresa { get; set; }
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