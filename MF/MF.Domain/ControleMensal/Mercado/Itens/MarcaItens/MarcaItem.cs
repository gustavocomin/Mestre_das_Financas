using MF.Domain.Commons.ClassesBase;

namespace MF.Domain.ControleMensal.Mercado.Itens.MarcaItens
{
    public class MarcaItem : IdBaseDtAlt
    {
        public string Descricao { get; set; }

        public int CodigoItem { get; set; }
        public Item Item { get; set; }
    }
}