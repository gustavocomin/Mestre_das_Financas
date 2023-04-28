using MF.Domain.ControleMensal.Mercado.Compras.Itens;
using MF.Domain.ControleMensal.Mercado.Compras.Itens.Models;

namespace MF.Application.ControleMensal.Mercado.Compras.Itens
{
    public class AplicItemCompra : IAplicItemCompra
    {
        private readonly IRepItemCompra _repItemCompra;

        public AplicItemCompra(IRepItemCompra repItemCompra)
        {
            _repItemCompra = repItemCompra;
        }

        public ItemCompraView Insert(ItemCompraDto dto)
        {
            try
            {
                ItemCompra ItemCompra = new(dto);
                _repItemCompra.SaveChanges(ItemCompra);
                ItemCompraView view = new(ItemCompra);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao inserir item na compra. Erro: {e.Message}");
            }
        }

        public ItemCompraView Update(int id, ItemCompraDto dto)
        {
            try
            {
                ItemCompra itemCompra = _repItemCompra.FindById<ItemCompra>(id) ?? throw new Exception($"Não foi possivél encontrar o item da compra de ID = {id} - Id da compra = {dto.CodigoCompra}.");
                itemCompra = new ItemCompra().AtualizaItemCompra(itemCompra, dto);
                _repItemCompra.SaveChanges(itemCompra);
                ItemCompraView view = new(itemCompra);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao alterar item da compra. Erro: {e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _repItemCompra.DeleteById<ItemCompra>(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar item da compra. Erro: {e.Message}");
            }
        }

        public void Delete(List<int> ids)
        {
            try
            {
                _repItemCompra.DeleteByIds<ItemCompra>(ids);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar item da compra. Erro: {e.Message}");
            }
        }

        public ItemCompraView FindById(int id)
        {
            try
            {
                ItemCompra itemCompra = _repItemCompra.FindById<ItemCompra>(id) ?? throw new Exception($"Não foi possivél encontrar o item da compra de ID = {id}.");
                ItemCompraView view = new(itemCompra);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar item da compra. Erro: {e.Message}");
            }
        }

        public List<ItemCompraView> FindAll()
        {
            try
            {
                List<ItemCompra> itemCompraes = _repItemCompra.FindAll<ItemCompra>();
                List<ItemCompraView> view = new ItemCompraView().ListItemCompraView(itemCompraes);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar item da compra. Erro: {e.Message}");
            }
        }
    }
}