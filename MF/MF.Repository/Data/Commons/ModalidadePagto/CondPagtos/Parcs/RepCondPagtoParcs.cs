using MF.Domain.Commons.ModalidadePagto.CondPagtos.Parcs;
using MF.Repository.Commons;
using MF.Repository.Configurations.Db;

namespace MF.Repository.Data.Commons.ModalidadePagto.CondPagtos.Parcs
{
    public class RepCondPagtoParcs : Rep<CondPagtoParcs>, IRepCondPagtoParcs
    {
        public RepCondPagtoParcs(DataContext contexto) : base(contexto)
        {
        }
    }
}