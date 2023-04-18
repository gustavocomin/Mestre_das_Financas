using MF.Domain.ControleMensal.Mercado.Itens.MarcaItens.Hist;
using MF.Repository.Commons;
using MF.Repository.Configurations.Db;

namespace MF.Repository.Data.ControleMensal.Mercado.Itens.MarcaItens.Hist
{
    public class RepMarcaItemHist : Rep<MarcaItemHist>
    {
        public RepMarcaItemHist(Contexto contexto) : base(contexto)
        {
        }
    }
}