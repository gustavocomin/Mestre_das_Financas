using MF.Domain.Commons.ClassesBase;
using MF.Domain.Commons.Consumirdores;
using MF.Domain.Planejamento.Itens;
using MF.Domain.Planejamento.Models;

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

        private void CalculaValorTotalCompra()
        {
            ValorTotalCompra = Itens?.Sum(x => x.ValorCompra) ?? 0;
        }

        private void CalculaValorTotalGuardado()
        {
            ValorTotalGuardado = Itens?.Sum(x => x.ValorGuardarMes) ?? 0;
        }

        public void AtualizaCalculos()
        {
            CalculaValorTotalCompra();
            CalculaValorTotalGuardado();
        }

        public Meta()
        {
        }

        public Meta(MetaDto meta)
        {
            Descricao = meta.Descricao;
            DataIniVigencia = meta.DataIniVigencia;
            DataFimVigencia = meta.DataFimVigencia;
            Status = meta.Status;
            CodigoConsumidor = meta.CodigoConsumidor;
            AtualizaCalculos();
        }

        public Meta AtualizaMeta(Meta meta, MetaDto metaDto)
        {
            meta.Descricao = metaDto.Descricao;
            meta.DataIniVigencia = metaDto.DataIniVigencia;
            meta.DataFimVigencia = metaDto.DataFimVigencia;
            meta.Status = metaDto.Status;
            meta.CodigoConsumidor = metaDto.CodigoConsumidor;
            AtualizaCalculos();

            return meta;
        }
    }
}