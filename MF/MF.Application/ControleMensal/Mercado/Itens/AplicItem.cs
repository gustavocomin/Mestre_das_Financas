using MF.Domain.ControleMensal.Mercado.Itens;
using MF.Domain.ControleMensal.Mercado.Itens.Models;

namespace MF.Application.ControleMensal.Mercado.Itens
{
    public class AplicItem : IAplicItem
    {
        private readonly IRepItem _repItem;

        public AplicItem(IRepItem repItem)
        {
            _repItem = repItem;
        }

        public ItemView Insert(ItemDto dto)
        {
            try
            {
                Item item = new(dto);
                _repItem.SaveChanges(item);
                ItemView view = new(item);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao inserir item. Erro: {e.Message}");
            }
        }

        public ItemView Update(int id, ItemDto dto)
        {
            try
            {
                Item item = _repItem.FindById<Item>(id) ?? throw new Exception($"Não foi possivél encontrar a item de ID = {id}.");
                item = new Item().AtualizaItem(item, dto);
                _repItem.SaveChanges(item);
                ItemView view = new(item);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao alterar item. Erro: {e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _repItem.DeleteById<Item>(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar item. Erro: {e.Message}");
            }
        }

        public void Delete(List<int> ids)
        {
            try
            {
                _repItem.DeleteByIds<Item>(ids);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar itens. Erro: {e.Message}");
            }
        }

        public ItemView FindById(int id)
        {
            try
            {
                Item item = _repItem.FindById<Item>(id) ?? throw new Exception($"Não foi possivél encontrar a item de ID = {id}.");
                ItemView view = new(item);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar item. Erro: {e.Message}");
            }
        }

        public List<ItemView> FindAll()
        {
            try
            {
                List<Item> items = _repItem.FindAll<Item>();
                List<ItemView> view = new ItemView().ListItemView(items);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar itens. Erro: {e.Message}");
            }
        }
    }
}