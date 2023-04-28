using MF.Domain.ControleMensal.Mercado.Compras.Models;

namespace MF.Application.ControleMensal.Mercado.Compras
{
    public interface IAplicCompra
    {
        void Delete(int id);
        void Delete(List<int> ids);
        List<CompraView> FindAll();
        CompraView FindById(int id);
        CompraView Insert(CompraDto dto);
        CompraView Update(int id, CompraDto dto);
    }
}