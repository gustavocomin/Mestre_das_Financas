using MF.Domain.Commons.ClassesBase;
using MF.Domain.Commons.ModalidadePagto.FormaPagtos.Models;

namespace MF.Domain.Commons.ModalidadePagto.FormaPagtos
{
    public class FormaPagto : IdBase
    {
        public string Descricao { get; set; }

        public FormaPagto()
        {
        }

        public FormaPagto(FormaPagtoDto formaPagto)
        {
            Descricao = formaPagto.Descricao;
        }

        public FormaPagto AtualizaFormaPagto(FormaPagto formaPagto, FormaPagtoDto formaPagtoDto)
        {
            formaPagto.Descricao = formaPagtoDto.Descricao;

            return formaPagto;
        }
    }
}