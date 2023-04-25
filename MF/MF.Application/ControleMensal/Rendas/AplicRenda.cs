using MF.Domain.ControleMensal.Rendas;
using MF.Domain.ControleMensal.Rendas.Models;

namespace MF.Application.ControleMensal.Rendas
{
    public class AplicRenda : IAplicRenda
    {
        private readonly IRepRenda _repRenda;

        public AplicRenda(IRepRenda repRenda)
        {
            _repRenda = repRenda;
        }

        public RendaView Insert(RendaDto dto)
        {
            try
            {
                Renda renda = new(dto);
                _repRenda.SaveChanges(renda);
                RendaView view = new(renda);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao inserir renda. Erro: {e.Message}");
            }
        }

        public RendaView Update(int id, RendaDto dto)
        {
            try
            {
                Renda renda = _repRenda.FindById<Renda>(id) ?? throw new Exception($"Não foi possivél encontrar a renda de ID = {id}.");
                Renda newRenda = new(dto);
                _repRenda.SaveChanges(newRenda);
                RendaView view = new(newRenda);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao alterar renda. Erro: {e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _repRenda.DeleteById<Renda>(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar renda. Erro: {e.Message}");
            }
        }

        public void Delete(List<int> ids)
        {
            try
            {
                _repRenda.DeleteByIds<Renda>(ids);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar renda. Erro: {e.Message}");
            }
        }

        public RendaView FindById(int id)
        {
            try
            {
                Renda renda = _repRenda.FindById<Renda>(id) ?? throw new Exception($"Não foi possivél encontrar o renda de ID = {id}.");
                RendaView view = new(renda);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar renda. Erro: {e.Message}");
            }
        }

        public List<RendaView> FindAll()
        {
            try
            {
                List<Renda> rendaes = _repRenda.FindAll<Renda>();
                List<RendaView> view = new RendaView().ListRendaView(rendaes);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar rendaes. Erro: {e.Message}");
            }
        }
    }
}