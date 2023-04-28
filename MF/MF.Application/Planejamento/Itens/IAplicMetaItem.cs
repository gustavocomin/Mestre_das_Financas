using MF.Domain.Planejamento.Itens.Models;

namespace MF.Application.Planejamento.Itens
{
    public interface IAplicMetaItem
    {
        void Delete(int id);
        void Delete(List<int> ids);
        List<MetaItemView> FindAll();
        MetaItemView FindById(int id);
        MetaItemView Insert(MetaItemDto dto);
        MetaItemView Update(int id, MetaItemDto dto);
    }
}