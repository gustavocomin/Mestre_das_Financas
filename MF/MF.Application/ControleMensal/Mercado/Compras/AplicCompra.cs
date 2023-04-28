using MF.Domain.ControleMensal.Mercado.Compras;
using MF.Domain.ControleMensal.Mercado.Compras.Models;

namespace MF.Application.ControleMensal.Mercado.Compras
{
    public class AplicCompra : IAplicCompra
    {
        private readonly IRepCompra _repCompra;

        public AplicCompra(IRepCompra repCompra)
        {
            _repCompra = repCompra;
        }

        public CompraView Insert(CompraDto dto)
        {
            try
            {
                Compra compra = new(dto);
                _repCompra.SaveChanges(compra);
                CompraView view = new(compra);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao inserir compra. Erro: {e.Message}");
            }
        }

        public CompraView Update(int id, CompraDto dto)
        {
            try
            {
                Compra compra = _repCompra.FindById<Compra>(id) ?? throw new Exception($"Não foi possivél encontrar a compra de ID = {id}.");
                compra = new Compra().AtualizaCompra(compra, dto);
                _repCompra.SaveChanges(compra);
                CompraView view = new(compra);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao alterar compra. Erro: {e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _repCompra.DeleteById<Compra>(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar compra. Erro: {e.Message}");
            }
        }

        public void Delete(List<int> ids)
        {
            try
            {
                _repCompra.DeleteByIds<Compra>(ids);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar compras. Erro: {e.Message}");
            }
        }

        public CompraView FindById(int id)
        {
            try
            {
                Compra compra = _repCompra.FindById<Compra>(id) ?? throw new Exception($"Não foi possivél encontrar a compra de ID = {id}.");
                CompraView view = new(compra);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar compra. Erro: {e.Message}");
            }
        }

        public List<CompraView> FindAll()
        {
            try
            {
                List<Compra> compras = _repCompra.FindAll<Compra>();
                List<CompraView> view = new CompraView().ListCompraView(compras);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar compras. Erro: {e.Message}");
            }
        }
    }
}