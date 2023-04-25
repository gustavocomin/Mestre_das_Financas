using MF.Domain.Planejamento.Itens;

namespace MF.Domain.Planejamento.Models
{
    public class MetaDto
    {
        public string Descricao { get; set; }
        public DateTime? DataIniVigencia { get; set; }
        public DateTime? DataFimVigencia { get; set; }
        public StatusMetaEItem Status { get; set; }
        public int CodigoConsumidor { get; set; }
    }
}