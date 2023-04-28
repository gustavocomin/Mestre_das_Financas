using MF.Domain.Commons.Consumirdores;
using MF.Domain.Commons.Consumirdores.Models;

namespace MF.Application.Commons.Consumirdores
{
    public class AplicConsumidor : IAplicConsumidor
    {
        private readonly IRepConsumidor _repConsumidor;

        public AplicConsumidor(IRepConsumidor repConsumidor)
        {
            _repConsumidor = repConsumidor;
        }

        public ConsumidorView Insert(ConsumidorDto dto)
        {
            try
            {
                Consumidor consumidor = new(dto);
                consumidor.AtualizaRenda();
                _repConsumidor.SaveChanges(consumidor);
                ConsumidorView view = new(consumidor);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao inserir consumidor. Erro: {e.Message}");
            }
        }

        public ConsumidorView Update(int id, ConsumidorDto dto)
        {
            try
            {
                Consumidor consumidor = _repConsumidor.FindById<Consumidor>(id) ?? throw new Exception($"Não foi possivél encontrar o consumidor de ID = {id}.");
                consumidor = new Consumidor().AtualizaConsumidor(consumidor, dto);
                _repConsumidor.SaveChanges(consumidor);
                ConsumidorView view = new(consumidor);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao alterar consumidor. Erro: {e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _repConsumidor.DeleteById<Consumidor>(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar consumidor. Erro: {e.Message}");
            }
        }

        public ConsumidorView FindById(int id)
        {
            try
            {
                Consumidor consumidor = _repConsumidor.FindById<Consumidor>(id) ?? throw new Exception($"Não foi possivél encontrar o consumidor de ID = {id}.");
                ConsumidorView view = new(consumidor);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar consumidor. Erro: {e.Message}");
            }
        }

        public List<ConsumidorView> FindAll()
        {
            try
            {
                List<Consumidor> consumidores = _repConsumidor.FindAll<Consumidor>();
                List<ConsumidorView> view = new ConsumidorView().ListConsumidorView(consumidores);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar consumidores. Erro: {e.Message}");
            }
        }
    }
}