using MF.Domain.Commons.ModalidadePagto.CondPagtos;
using MF.Repository.Commons;
using MF.Repository.Configurations.Db;

namespace MF.Repository.Data.Commons.ModalidadePagto.CondPagtos
{
    public class RepCondPagto : Rep<CondPagto>
    {
        public RepCondPagto(Contexto contexto) : base(contexto)
        {
        }
    }
}