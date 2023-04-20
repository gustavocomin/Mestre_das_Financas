using MF.Domain.Commons.ClassesBase;
using MF.Domain.ControleMensal.Mercado.Itens.MarcaItens;

namespace MF.Domain.ControleMensal.Mercado.Itens
{
    public class Item : IdBase
    {
        public string Descricao { get; set; }

        public List<MarcaItem> MarcaItens { get; set; }
    }
}