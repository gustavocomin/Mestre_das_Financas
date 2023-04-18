using MF.Domain.Commons.ModalidadePagto.FormaPagtos;
using MF.Repository.Commons;
using MF.Repository.Configurations.Db;

namespace MF.Repository.Data.Commons.ModalidadePagto.FormaPagtos
{
    public class RepFormaPagto : Rep<FormaPagto>
    {
        public RepFormaPagto(Contexto contexto) : base(contexto)
        {
        }
    }
}