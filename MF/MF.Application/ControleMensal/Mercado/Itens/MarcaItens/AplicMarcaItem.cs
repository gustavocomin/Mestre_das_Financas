using MF.Domain.ControleMensal.Mercado.Itens.MarcaItens;
using MF.Domain.ControleMensal.Mercado.Itens.MarcaItens.Models;

namespace MF.Application.ControleMensal.Mercado.Itens.MarcaItens
{
    public class AplicMarcaItem : IAplicMarcaItem
    {
        private readonly IRepMarcaItem _repMarcaItem;

        public AplicMarcaItem(IRepMarcaItem repMarcaItem)
        {
            _repMarcaItem = repMarcaItem;
        }

        public MarcaItemView Insert(MarcaItemDto dto)
        {
            try
            {
                MarcaItem MarcaItem = new(dto);
                _repMarcaItem.SaveChanges(MarcaItem);
                MarcaItemView view = new(MarcaItem);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao inserir marca. Erro: {e.Message}");
            }
        }

        public MarcaItemView Update(int id, MarcaItemDto dto)
        {
            try
            {
                MarcaItem MarcaItem = _repMarcaItem.FindById<MarcaItem>(id) ?? throw new Exception($"Não foi possivél encontrar a marca de ID = {id} -  ID do item = {dto.CodigoItem}.");
                MarcaItem = new MarcaItem().AtualizaMarcaItem(MarcaItem, dto);
                _repMarcaItem.SaveChanges(MarcaItem);
                MarcaItemView view = new(MarcaItem);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao alterar marca. Erro: {e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _repMarcaItem.DeleteById<MarcaItem>(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar marca. Erro: {e.Message}");
            }
        }

        public void Delete(List<int> ids)
        {
            try
            {
                _repMarcaItem.DeleteByIds<MarcaItem>(ids);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar marcas. Erro: {e.Message}");
            }
        }

        public MarcaItemView FindById(int id)
        {
            try
            {
                MarcaItem marcaItem = _repMarcaItem.FindById<MarcaItem>(id) ?? throw new Exception($"Não foi possivél encontrar a marca de ID = {id}.");
                MarcaItemView view = new(marcaItem);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar marca. Erro: {e.Message}");
            }
        }

        public List<MarcaItemView> FindAll()
        {
            try
            {
                List<MarcaItem> marcaItens = _repMarcaItem.FindAll<MarcaItem>();
                List<MarcaItemView> view = new MarcaItemView().ListMarcaItemView(marcaItens);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar marcas. Erro: {e.Message}");
            }
        }
    }
}