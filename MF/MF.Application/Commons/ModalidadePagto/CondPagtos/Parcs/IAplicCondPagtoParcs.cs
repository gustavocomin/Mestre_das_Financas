using MF.Domain.Commons.ModalidadePagto.CondPagtos.Parcs.Models;

namespace MF.Application.Commons.ModalidadePagto.CondPagtos.Parcs
{
    public interface IAplicCondPagtoParcs
    {
        void Delete(int id);
        void Delete(List<int> ids);
        List<CondPagtoParcsView> FindAll();
        List<CondPagtoParcsView> FindById(int idCondPagto);
        List<CondPagtoParcsView> Insert(CondPagtoParcsDto dto);
        List<CondPagtoParcsView> Update(int idCondPagto, CondPagtoParcsDto dto);
    }
}