using MF.Domain.Planejamento.Itens;
using MF.Domain.Planejamento.Itens.Models;

namespace MF.Application.Planejamento.Itens
{
    public class AplicMetaItem : IAplicMetaItem
    {
        private readonly IRepMetaItem _repMetaItem;

        public AplicMetaItem(IRepMetaItem repMetaItem)
        {
            _repMetaItem = repMetaItem;
        }

        public MetaItemView Insert(MetaItemDto dto)
        {
            try
            {
                MetaItem metaItem = new(dto);
                _repMetaItem.SaveChanges(metaItem);
                MetaItemView view = new(metaItem);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao inserir item da meta. Erro: {e.Message}");
            }
        }

        public MetaItemView Update(int id, MetaItemDto dto)
        {
            try
            {
                MetaItem metaItem = _repMetaItem.FindById<MetaItem>(id) ?? throw new Exception($"Não foi possivél encontrar o item da meta de ID = {id}.");
                metaItem = new MetaItem().AtualizaMetaItem(metaItem, dto);
                _repMetaItem.SaveChanges(metaItem);
                MetaItemView view = new(metaItem);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao alterar item da meta. Erro: {e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _repMetaItem.DeleteById<MetaItem>(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar item da meta. Erro: {e.Message}");
            }
        }

        public void Delete(List<int> ids)
        {
            try
            {
                _repMetaItem.DeleteByIds<MetaItem>(ids);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar itens da meta. Erro: {e.Message}");
            }
        }

        public MetaItemView FindById(int id)
        {
            try
            {
                MetaItem metaItem = _repMetaItem.FindById<MetaItem>(id) ?? throw new Exception($"Não foi possivél encontrar o item da meta de ID = {id}.");
                MetaItemView view = new(metaItem);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar item da meta. Erro: {e.Message}");
            }
        }

        public List<MetaItemView> FindAll()
        {
            try
            {
                List<MetaItem> metaItens = _repMetaItem.FindAll<MetaItem>();
                List<MetaItemView> view = new MetaItemView().ListMetaItemView(metaItens);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar itens de meta. Erro: {e.Message}");
            }
        }
    }
}