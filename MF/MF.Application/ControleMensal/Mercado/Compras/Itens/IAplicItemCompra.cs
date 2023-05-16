using HtmlAgilityPack;
using MF.Domain.ControleMensal.Mercado.Compras.Itens;
using MF.Domain.ControleMensal.Mercado.Compras.Itens.Models;

namespace MF.Application.ControleMensal.Mercado.Compras.Itens
{
    public interface IAplicItemCompra
    {
        void Delete(int id);
        void Delete(List<int> ids);
        List<ItemCompraView> FindAll();
        ItemCompraView FindById(int id);
        List<ItemCompra> ImportarItensNFCE(HtmlNodeCollection tdNodes, int id);
        ItemCompraView Insert(ItemCompraDto dto);
        ItemCompraView Update(int id, ItemCompraDto dto);
    }
}