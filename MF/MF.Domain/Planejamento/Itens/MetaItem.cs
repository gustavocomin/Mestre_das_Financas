using MF.Domain.Commons.ClassesBase;

namespace MF.Domain.Planejamento.Itens
{
    public class MetaItem : IdBaseDtAlt
    {
        public MetaItem()
        {
            Status = StatusMetaEItem.Ativo;
        }

        public string Descricao { get; set; }
        public decimal ValorCompra { get; set; }
        public string LinkCompra { get; set; }
        public decimal ValorReservaCompra { get; set; }
        public decimal DiferencaCompraReserva { get; private set; }
        public DateTime DataExpectativaAquisicao { get; set; }
        public decimal ValorGuardarMes { get; private set; }
        public StatusMetaEItem Status { get; set; }

        public void CalculaValorGuardarMes()
        {
            TimeSpan diff = DataExpectativaAquisicao - DataAlteracao;
            int meses = (int)(diff.TotalDays / 30.44);

            ValorGuardarMes = Math.Round(DiferencaCompraReserva / meses, 2, MidpointRounding.ToEven);
        }

        public void CalculaDiferenca()
        {
            DiferencaCompraReserva = ValorCompra - ValorReservaCompra;
        }
    }

    public enum StatusMetaEItem
    {
        Ativo = 0,
        Inativo = 1,
        Parado = 2,
        Finalizado = 3
    }
}