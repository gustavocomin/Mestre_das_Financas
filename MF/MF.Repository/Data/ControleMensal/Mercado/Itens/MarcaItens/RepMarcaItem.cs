using MF.Domain.ControleMensal.Mercado.Itens.MarcaItens;
using MF.Repository.Commons;
using MF.Repository.Configurations.Db;

namespace MF.Repository.Data.ControleMensal.Mercado.Itens.MarcaItens
{
    public class RepMarcaItem : Rep<MarcaItem>
    {
        public RepMarcaItem(Contexto contexto) : base(contexto)
        {
        }
    }
}