using MF.Domain.ControleMensal.Mercado.Itens.Models;

namespace MF.Application.ControleMensal.Mercado.Itens
{
    public interface IAplicItem
    {
        void Delete(int id);
        void Delete(List<int> ids);
        List<ItemView> FindAll();
        ItemView FindById(int id);
        ItemView Insert(ItemDto dto);
        ItemView Update(int id, ItemDto dto);
    }
}