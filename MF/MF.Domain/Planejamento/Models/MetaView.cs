using MF.Domain.Commons.ClassesBase;
using MF.Domain.Commons.Consumirdores.Models;
using MF.Domain.Planejamento.Itens;
using MF.Domain.Planejamento.Itens.Models;

namespace MF.Domain.Planejamento.Models
{
    public class MetaView : IdBaseDtAlt
    {
        public string Descricao { get; set; }
        public DateTime? DataIniVigencia { get; set; }
        public DateTime? DataFimVigencia { get; set; }
        public decimal ValorTotalCompra { get; set; }
        public decimal ValorTotalGuardado { get; set; }
        public StatusMetaEItem Status { get; set; }

        public int CodigoConsumidor { get; set; }

        public ConsumidorView Consumidor { get; set; }

        public List<MetaItemView>? Itens { get; set; }

        public MetaView()
        {
        }

        public MetaView(Meta meta)
        {
            Id = meta.Id;
            Descricao = meta.Descricao;
            DataIniVigencia = meta.DataIniVigencia;
            DataFimVigencia = meta.DataFimVigencia;
            ValorTotalCompra = meta.ValorTotalCompra;
            ValorTotalGuardado = meta.ValorTotalGuardado;
            Status = meta.Status;
            CodigoConsumidor = meta.CodigoConsumidor;
            Consumidor = new ConsumidorView(meta.Consumidor);
            Itens = (meta.Itens != null && meta.Itens.Count > 0) ? new MetaItemView().ListMetaItemView(meta.Itens) : null;
        }

        public List<MetaView> ListMetaView(List<Meta> metas)
        {
            List<MetaView> list = new();
            metas.ForEach(x =>
            {
                list.Add(new MetaView(x));
            });
            return list;
        }
    }
}