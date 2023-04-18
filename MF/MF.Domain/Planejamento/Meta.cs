using MF.Domain.Commons.ClassesBase;
using MF.Domain.Commons.Consumirdores;
using MF.Domain.Planejamento.Itens;

namespace MF.Domain.Planejamento
{
    public class Meta : IdBaseDtAlt
    {
        public string Descricao { get; set; }
        public DateTime? DataIniVigencia { get; set; }
        public DateTime? DataFimVigencia { get; set; }
        public decimal ValorTotalCompra { get; private set; }
        public decimal ValorTotalGuardado { get; private set; }
        public StatusMetaEItem Status { get; set; }

        public int CodigoConsumidor { get; set; }

        public Consumidor Consumidor { get; set; }

        public List<MetaItem> Itens { get; set; }

        public void CalculaValorTotalCompra()
        {
            ValorTotalCompra = Itens?.Sum(x => x.ValorCompra) ?? 0;
        }

        public void CalculaValorTotalGuardado()
        {
            ValorTotalGuardado = Itens?.Sum(x => x.ValorGuardarMes) ?? 0;
        }
    }
}