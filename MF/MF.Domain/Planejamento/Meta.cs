using MF.Domain.Commons.ClassesBase;
using MF.Domain.Commons.Consumirdores;

namespace MF.Domain.Planejamento
{
    public class Meta : IdBaseDtAlt
    {
        public Meta()
        {
            ValorTotalCompra = Itens?.Sum(x => x.ValorCompra) ?? 0;
            ValorTotalGuardado = Itens?.Sum(x => x.ValorGuardarMes) ?? 0;
        }

        public string Descricao { get; set; }
        public DateTime? DataIniVigencia { get; set; }
        public DateTime? DataFimVigencia { get; set; }
        private decimal ValorTotalCompra { get; set; }
        private decimal ValorTotalGuardado { get; set; }
        public StatusMetaEItem Status { get; set; }

        public int CodigoConsumidor { get; set; }

        public Consumidor Consumidor { get; set; }

        public List<MetaItem> Itens { get; set; }
    }
}