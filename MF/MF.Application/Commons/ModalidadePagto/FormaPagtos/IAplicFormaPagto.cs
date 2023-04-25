using MF.Domain.Commons.ModalidadePagto.FormaPagtos.Models;

namespace MF.Application.Commons.ModalidadePagto.FormaPagtos
{
    public interface IAplicFormaPagto
    {
        void Delete(int id);
        void Delete(List<int> ids);
        List<FormaPagtoView> FindAll();
        FormaPagtoView FindById(int id);
        FormaPagtoView Insert(FormaPagtoDto dto);
        FormaPagtoView Update(int id, FormaPagtoDto dto);
    }
}