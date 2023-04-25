using MF.Domain.Commons.ClassesBase;
using MF.Domain.ControleMensal.Mercado.Itens.Models;

namespace MF.Domain.ControleMensal.Mercado.Itens.MarcaItens.Models
{
    public class MarcaItemView : IdBaseDtAlt
    {
        public string Descricao { get; set; }
        public int CodigoItem { get; set; }
        public ItemView Item { get; set; }

        public MarcaItemView()
        {
        }

        public MarcaItemView(MarcaItem marcaItem)
        {
            Descricao = marcaItem.Descricao;
            CodigoItem = marcaItem.CodigoItem;
            Item = new ItemView(marcaItem.Item);
        }

        public List<MarcaItemView> ListMarcaItemView(List<MarcaItem> marcaItens)
        {
            List<MarcaItemView> list = new();
            marcaItens.ForEach(x =>
            {
                list.Add(new MarcaItemView(x));
            });
            return list;
        }
    }
}