using MF.Domain.ControleMensal.Rendas;
using MF.Repository.Commons;
using MF.Repository.Configurations.Db;

namespace MF.Repository.Data.ControleMensal.Rendas
{
    public class RepRenda : Rep<Renda>
    {
        public RepRenda(Contexto contexto) : base(contexto)
        {
        }
    }
}