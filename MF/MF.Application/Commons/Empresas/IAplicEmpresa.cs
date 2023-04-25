using MF.Domain.Commons.Empresas.Models;

namespace MF.Application.Commons.Empresas
{
    public interface IAplicEmpresa
    {
        void Delete(int id);
        void Delete(List<int> ids);
        List<EmpresaView> FindAll();
        EmpresaView FindById(int id);
        EmpresaView Insert(EmpresaDto dto);
        EmpresaView Update(int id, EmpresaDto dto);
    }
}