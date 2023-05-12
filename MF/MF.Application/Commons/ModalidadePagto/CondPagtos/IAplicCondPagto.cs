using MF.Domain.Commons.ModalidadePagto.CondPagtos.Models;

namespace MF.Application.Commons.ModalidadePagto.CondPagtos
{
    public interface IAplicCondPagto
    {
        void Delete(int id);
        void Delete(List<int> ids);
        List<CondPagtoView> FindAll();
        CondPagtoView FindById(int id);
        CondPagtoView Insert(CondPagtoDto dto);
        CondPagtoView Update(int id, CondPagtoDto dto);
    }
}