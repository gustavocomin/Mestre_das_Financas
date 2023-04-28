using MF.Domain.Planejamento.Models;

namespace MF.Application.Planejamento
{
    public interface IAplicMeta
    {
        void Delete(int id);
        void Delete(List<int> ids);
        List<MetaView> FindAll();
        MetaView FindById(int id);
        MetaView Insert(MetaDto dto);
        MetaView Update(int id, MetaDto dto);
    }
}