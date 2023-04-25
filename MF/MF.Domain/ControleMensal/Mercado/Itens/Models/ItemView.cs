using MF.Domain.Commons.ClassesBase;
using MF.Domain.ControleMensal.Mercado.Itens.MarcaItens.Models;

namespace MF.Domain.ControleMensal.Mercado.Itens.Models
{
    public class ItemView : IdBase
    {
        public string Descricao { get; set; }
        public List<MarcaItemView>? MarcaItens { get; set; }

        public ItemView()
        {
        }

        public ItemView(Item item)
        {
            Descricao = item.Descricao;
            MarcaItens = (item.MarcaItens != null && item.MarcaItens.Count > 0) ? new MarcaItemView().ListMarcaItemView(item.MarcaItens) : null;
        }

        public List<ItemView> ListItemView(List<Item> itens)
        {
            List<ItemView> list = new();
            itens.ForEach(it =>
            {
                itens.Add(it);
            });
            return list;
        }
    }
}