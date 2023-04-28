using MF.Domain.ControleMensal.Despesas;
using MF.Domain.ControleMensal.Despesas.Models;

namespace MF.Application.ControleMensal.Despesas
{
    public class AplicDespesa : IAplicDespesa
    {
        private readonly IRepDespesa _repDespesa;

        public AplicDespesa(IRepDespesa repDespesa)
        {
            _repDespesa = repDespesa;
        }

        public DespesaView Insert(DespesaDto dto)
        {
            try
            {
                Despesa despesa = new(dto);
                _repDespesa.SaveChanges(despesa);
                DespesaView view = new(despesa);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao inserir despesa. Erro: {e.Message}");
            }
        }

        public DespesaView Update(int id, DespesaDto dto)
        {
            try
            {
                Despesa despesa = _repDespesa.FindById<Despesa>(id) ?? throw new Exception($"Não foi possivél encontrar a despesa de ID = {id}.");
                despesa = new Despesa().AtualizaDespesa(despesa, dto);
                _repDespesa.SaveChanges(despesa);
                DespesaView view = new(despesa);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao alterar despesa. Erro: {e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _repDespesa.DeleteById<Despesa>(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar despesa. Erro: {e.Message}");
            }
        }

        public void Delete(List<int> ids)
        {
            try
            {
                _repDespesa.DeleteByIds<Despesa>(ids);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar despesa. Erro: {e.Message}");
            }
        }

        public DespesaView FindById(int id)
        {
            try
            {
                Despesa despesa = _repDespesa.FindById<Despesa>(id) ?? throw new Exception($"Não foi possivél encontrar o despesa de ID = {id}.");
                DespesaView view = new(despesa);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar despesa. Erro: {e.Message}");
            }
        }

        public List<DespesaView> FindAll()
        {
            try
            {
                List<Despesa> despesaes = _repDespesa.FindAll<Despesa>();
                List<DespesaView> view = new DespesaView().ListDespesaView(despesaes);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar despesaes. Erro: {e.Message}");
            }
        }
    }
}