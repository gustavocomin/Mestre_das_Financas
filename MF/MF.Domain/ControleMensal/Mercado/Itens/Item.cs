using MF.Domain.Commons.ClassesBase;
using MF.Domain.ControleMensal.Mercado.Itens.MarcaItens;
using MF.Domain.ControleMensal.Mercado.Itens.Models;

namespace MF.Domain.ControleMensal.Mercado.Itens
{
    public class Item : IdBase
    {
        public string Descricao { get; set; }

        public List<MarcaItem> MarcaItens { get; set; }

        public Item()
        {
        }

        public Item(ItemDto item)
        {
            Descricao = item.Descricao;
        }

        public Item AtualizaItem(Item item, ItemDto itemDto)
        {
            item.Descricao = itemDto.Descricao;

            return item;
        }
    }
}