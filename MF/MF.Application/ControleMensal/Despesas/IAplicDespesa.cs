using MF.Domain.ControleMensal.Despesas.Models;

namespace MF.Application.ControleMensal.Despesas
{
    public interface IAplicDespesa
    {
        void Delete(int id);
        void Delete(List<int> ids);
        List<DespesaView> FindAll();
        DespesaView FindById(int id);
        DespesaView Insert(DespesaDto dto);
        DespesaView Update(int id, DespesaDto dto);
    }
}