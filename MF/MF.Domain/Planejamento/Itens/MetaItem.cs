using MF.Domain.Commons.ClassesBase;
using MF.Domain.Planejamento.Itens.Models;

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
        public string? LinkCompra { get; set; }
        public decimal ValorReservaCompra { get; set; }
        public decimal DiferencaCompraReserva { get; private set; }
        public DateTime DataExpectativaAquisicao { get; set; }
        public decimal ValorGuardarMes { get; private set; }
        public StatusMetaEItem Status { get; set; }

        public int CodigoMeta { get; set; }

        public Meta Meta { get; set; }


        private void CalculaValorGuardarMes()
        {
            TimeSpan diff = DataExpectativaAquisicao - DataAlteracao;
            int meses = (int)(diff.TotalDays / 30.44);

            ValorGuardarMes = Math.Round(DiferencaCompraReserva / meses, 2, MidpointRounding.ToEven);
        }

        private void CalculaDiferenca()
        {
            DiferencaCompraReserva = ValorCompra - ValorReservaCompra;
        }

        public void AtualizaCalculos()
        {
            CalculaValorGuardarMes();
            CalculaDiferenca();
        }

        public MetaItem(MetaItemDto metaItem)
        {
            Descricao = metaItem.Descricao;
            ValorCompra = metaItem.ValorCompra;
            LinkCompra = metaItem.LinkCompra;
            ValorReservaCompra = metaItem.ValorReservaCompra;
            DataExpectativaAquisicao = metaItem.DataExpectativaAquisicao;
            Status = metaItem.Status;
            CodigoMeta = metaItem.CodigoMeta;
            AtualizaCalculos();
        }

        public MetaItem AtualizaMetaItem(MetaItem metaItem, MetaItemDto metaItemDto)
        {
            metaItem.Descricao = metaItemDto.Descricao;
            metaItem.ValorCompra = metaItemDto.ValorCompra;
            metaItem.LinkCompra = metaItemDto.LinkCompra;
            metaItem.ValorReservaCompra = metaItemDto.ValorReservaCompra;
            metaItem.DataExpectativaAquisicao = metaItemDto.DataExpectativaAquisicao;
            metaItem.Status = metaItemDto.Status;
            metaItem.CodigoMeta = metaItemDto.CodigoMeta;
            AtualizaCalculos();

            return metaItem;
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