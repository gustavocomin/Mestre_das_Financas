using MF.Domain.Commons.ClassesBase;

namespace MF.Domain.Commons.ModalidadePagto.FormaPagtos.Models
{
    public class FormaPagtoView : IdBase
    {
        public string Descricao { get; set; }

        public FormaPagtoView()
        {
        }

        public FormaPagtoView(FormaPagto formaPagto)
        {
            Id = formaPagto.Id;
            Descricao = formaPagto.Descricao;
        }

        public List<FormaPagtoView> ListFormaPagtoView(List<FormaPagto> formaPagtos)
        {
            List<FormaPagtoView> list = new();
            formaPagtos.ForEach(x =>
            {
                list.Add(new FormaPagtoView(x));
            });
            return list;
        }
    }
}