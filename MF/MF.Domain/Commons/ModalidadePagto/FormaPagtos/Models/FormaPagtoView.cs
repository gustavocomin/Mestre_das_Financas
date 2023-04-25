using MF.Domain.Commons.ClassesBase;

namespace MF.Domain.Commons.ModalidadePagto.FormaPagtos.Models
{
    public class FormaPagtoView : IdBase
    {
        public string Descricao { get; set; }

        public FormaPagtoView(FormaPagto formaPagto)
        {
            Id = formaPagto.Id;
            Descricao = formaPagto.Descricao;
        }
    }
}