using MF.Domain.ControleMensal.Rendas.Models;

namespace MF.Application.ControleMensal.Rendas
{
    public interface IAplicRenda
    {
        void Delete(int id);
        void Delete(List<int> ids);
        List<RendaView> FindAll();
        RendaView FindById(int id);
        RendaView Insert(RendaDto dto);
        RendaView Update(int id, RendaDto dto);
    }
}