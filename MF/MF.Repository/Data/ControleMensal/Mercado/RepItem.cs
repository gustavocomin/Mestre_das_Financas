using MF.Domain.ControleMensal.Mercado.Itens;
using MF.Repository.Commons;
using MF.Repository.Configurations.Db;

namespace MF.Repository.Data.ControleMensal.Mercado
{
    public class RepItem : Rep<Item>
    {
        public RepItem(Contexto contexto) : base(contexto)
        {
        }
    }
}