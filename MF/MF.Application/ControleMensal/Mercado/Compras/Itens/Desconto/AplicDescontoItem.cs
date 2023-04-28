using MF.Domain.ControleMensal.Mercado.Compras.Itens.Desconto;
using MF.Domain.ControleMensal.Mercado.Compras.Itens.Desconto.Models;

namespace MF.Application.ControleMensal.Mercado.Compras.Itens.Desconto
{
    public class AplicDescontoItem : IAplicDescontoItem
    {
        private readonly IRepDescontoItem _repDescontoItem;

        public AplicDescontoItem(IRepDescontoItem repDescontoItem)
        {
            _repDescontoItem = repDescontoItem;
        }

        public DescontoItemView Insert(DescontoItemDto dto)
        {
            try
            {
                DescontoItem descontoItem = new(dto);
                _repDescontoItem.SaveChanges(descontoItem);
                DescontoItemView view = new(descontoItem);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao inserir desconto ao item. Erro: {e.Message}");
            }
        }

        public DescontoItemView Update(int id, DescontoItemDto dto)
        {
            try
            {
                DescontoItem descontoItem = _repDescontoItem.FindById<DescontoItem>(id) ?? throw new Exception($"Não foi possivél encontrar a desconto do item de ID = {id}");
                DescontoItem newDescontoItem = new(dto);
                _repDescontoItem.SaveChanges(newDescontoItem);
                DescontoItemView view = new(newDescontoItem);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao alterar desconto do item. Erro: {e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _repDescontoItem.DeleteById<DescontoItem>(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar desconto do item. Erro: {e.Message}");
            }
        }

        public void Delete(List<int> ids)
        {
            try
            {
                _repDescontoItem.DeleteByIds<DescontoItem>(ids);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar desconto do item. Erro: {e.Message}");
            }
        }

        public DescontoItemView FindById(int id)
        {
            try
            {
                DescontoItem descontoItem = _repDescontoItem.FindById<DescontoItem>(id) ?? throw new Exception($"Não foi possivél encontrar o desconto do item de ID = {id}.");
                DescontoItemView view = new(descontoItem);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar desconto do item. Erro: {e.Message}");
            }
        }

        public List<DescontoItemView> FindAll()
        {
            try
            {
                List<DescontoItem> descontoItemes = _repDescontoItem.FindAll<DescontoItem>();
                List<DescontoItemView> view = new DescontoItemView().ListDescontoItemView(descontoItemes);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar descontoItems. Erro: {e.Message}");
            }
        }
    }
}