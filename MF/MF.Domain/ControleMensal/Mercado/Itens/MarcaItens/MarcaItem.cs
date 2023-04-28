using MF.Domain.Commons.ClassesBase;
using MF.Domain.ControleMensal.Mercado.Itens.MarcaItens.Models;

namespace MF.Domain.ControleMensal.Mercado.Itens.MarcaItens
{
    public class MarcaItem : IdBaseDtAlt
    {
        public string Descricao { get; set; }

        public int CodigoItem { get; set; }
        public Item Item { get; set; }

        public MarcaItem()
        {
        }

        public MarcaItem(MarcaItemDto marcaItem)
        {
            Descricao = marcaItem.Descricao;
            CodigoItem = marcaItem.CodigoItem;
        }

        public MarcaItem AtualizaMarcaItem(MarcaItem marcaItem, MarcaItemDto marcaItemDto)
        {
            marcaItem.Descricao = marcaItemDto.Descricao;
            marcaItem.CodigoItem = marcaItemDto.CodigoItem;

            return marcaItem;
        }
    }
}