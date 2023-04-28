using MF.Domain.ControleMensal.Mercado.Compras.Itens.Desconto.Models;

namespace MF.Application.ControleMensal.Mercado.Compras.Itens.Desconto
{
    public interface IAplicDescontoItem
    {
        void Delete(int id);
        void Delete(List<int> ids);
        List<DescontoItemView> FindAll();
        DescontoItemView FindById(int id);
        DescontoItemView Insert(DescontoItemDto dto);
        DescontoItemView Update(int id, DescontoItemDto dto);
    }
}