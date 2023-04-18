using MF.Domain.Commons.ModalidadePagto.CondPagtos;

namespace MF.Domain.Commons.ModalidadePagto.FormaPagtos
{
    public class FormaPagto
    {
        public string Descricao { get; set; }

        public int CodigoCongPagto { get; set; }

        public virtual CondPagto CondPagto { get; set; }
    }
}