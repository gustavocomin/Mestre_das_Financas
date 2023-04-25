using MF.Domain.Commons.ModalidadePagto.CondPagtos;
using MF.Domain.Commons.ModalidadePagto.CondPagtos.Models;

namespace MF.Application.Commons.ModalidadePagto.CondPagtos
{
    public class AplicCondPagto : IAplicCondPagto
    {
        private readonly IRepCondPagto _repCondPagto;

        public AplicCondPagto(IRepCondPagto repCondPagto)
        {
            _repCondPagto = repCondPagto;
        }

        public CondPagtoView Insert(CondPagtoDto dto)
        {
            try
            {
                CondPagto condPagto = new(dto);
                _repCondPagto.SaveChanges(condPagto);
                CondPagtoView view = new(condPagto);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao inserir condição de pagamento. Erro: {e.Message}");
            }
        }

        public CondPagtoView Update(int id, CondPagtoDto dto)
        {
            try
            {
                CondPagto condPagto = _repCondPagto.FindById<CondPagto>(id) ?? throw new Exception($"Não foi possivél encontrar a condição de pagamento de ID = {id}.");
                CondPagto newEmpresa = new(dto);
                _repCondPagto.SaveChanges(newEmpresa);
                CondPagtoView view = new(newEmpresa);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao alterar condição de pagamento. Erro: {e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _repCondPagto.DeleteById<CondPagto>(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar condição de pagamento. Erro: {e.Message}");
            }
        }

        public CondPagtoView FindById(int id)
        {
            try
            {
                CondPagto condPagto = _repCondPagto.FindById<CondPagto>(id) ?? throw new Exception($"Não foi possivél encontrar o condição de pagamento de ID = {id}.");
                CondPagtoView view = new(condPagto);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar condição de pagamento. Erro: {e.Message}");
            }
        }

        public List<CondPagtoView> FindAll()
        {
            try
            {
                List<CondPagto> condPagtos = _repCondPagto.FindAll<CondPagto>();
                List<CondPagtoView> view = new CondPagtoView().ListCondPagtoView(condPagtos);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar condições de pagamento. Erro: {e.Message}");
            }
        }
    }
}