using MF.Domain.ControleMensal.Mercado.Itens.MarcaItens.Models;

namespace MF.Application.ControleMensal.Mercado.Itens.MarcaItens
{
    public interface IAplicMarcaItem
    {
        void Delete(int id);
        void Delete(List<int> ids);
        List<MarcaItemView> FindAll();
        MarcaItemView FindById(int id);
        MarcaItemView Insert(MarcaItemDto dto);
        MarcaItemView Update(int id, MarcaItemDto dto);
    }
}