using MF.Domain.Commons.ClassesBase;
using MF.Domain.ControleMensal.Mercado.Itens.MarcaItens.Hist;

namespace MF.Domain.ControleMensal.Mercado.Itens.MarcaItens
{
    public class MarcaItem : IdBaseDtAlt
    {
        public string Descricao { get; set; }

        public List<MarcaItemHist> Hists { get; set; }
    }
}