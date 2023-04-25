using MF.Domain.Commons.ClassesBase;
using MF.Domain.Planejamento.Models;

namespace MF.Domain.Planejamento.Itens.Models
{
    public class MetaItemView : IdBaseDtAlt
    {
        public string Descricao { get; set; }
        public decimal ValorCompra { get; set; }
        public string? LinkCompra { get; set; }
        public decimal ValorReservaCompra { get; set; }
        public decimal DiferencaCompraReserva { get; private set; }
        public DateTime DataExpectativaAquisicao { get; set; }
        public decimal ValorGuardarMes { get; private set; }
        public StatusMetaEItem Status { get; set; }

        public int CodigoMeta { get; set; }

        public MetaView Meta { get; set; }

        public MetaItemView()
        {
        }

        public MetaItemView(MetaItem metaItem)
        {
            Id = metaItem.Id;
            Descricao = metaItem.Descricao;
            ValorCompra = metaItem.ValorCompra;
            LinkCompra = metaItem.LinkCompra;
            ValorReservaCompra = metaItem.ValorReservaCompra;
            DiferencaCompraReserva = metaItem.DiferencaCompraReserva;
            DataExpectativaAquisicao = metaItem.DataExpectativaAquisicao;
            ValorGuardarMes = metaItem.ValorGuardarMes;
            Status = metaItem.Status;
            CodigoMeta = metaItem.CodigoMeta;
            Meta = new MetaView(metaItem.Meta);
        }

        public List<MetaItemView> ListMetaItemView(List<MetaItem> metaItens)
        {
            List<MetaItemView> list = new();
            metaItens.ForEach(metaItem =>
            {
                list.Add(new MetaItemView(metaItem));
            });

            return list;
        }
    }
}