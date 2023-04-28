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
                _repConsumidor.SaveChanges(consumidor);
                ConsumidorView view = new(consumidor);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao inserir consumidor. Erro: {e.Message} - {e.InnerException}");
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

        public void Delete(List<int> ids)
        {
            try
            {
                _repConsumidor.DeleteByIds<Consumidor>(ids);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar consumidores. Erro: {e.Message}");
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
                List<ConsumidorView> view = new();
                List<Consumidor> consumidores = _repConsumidor.FindAll<Consumidor>();
                if (consumidores != null && consumidores.Count > 0)
                    view = new ConsumidorView().ListConsumidorView(consumidores);

                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar consumidores. Erro: {e.Message}");
            }
        }

        public ConsumidorView FindByEmail(string email)
        {
            try
            {
                ConsumidorView consumidor = FindAll().Where(x => x.Email.Trim().ToUpper() == email.Trim().ToUpper()).FirstOrDefault();

                return consumidor;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar consumidor por Email. Email = {email}. Erro: {e.Message} - {e.InnerException}");
            }
        }
    }
}