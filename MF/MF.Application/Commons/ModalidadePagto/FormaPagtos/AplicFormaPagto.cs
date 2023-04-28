using MF.Domain.Commons.ModalidadePagto.FormaPagtos;
using MF.Domain.Commons.ModalidadePagto.FormaPagtos.Models;

namespace MF.Application.Commons.ModalidadePagto.FormaPagtos
{
    public class AplicFormaPagto : IAplicFormaPagto
    {
        private readonly IRepFormaPagto _repFormaPagto;

        public AplicFormaPagto(IRepFormaPagto repFormaPagto)
        {
            _repFormaPagto = repFormaPagto;
        }

        public FormaPagtoView Insert(FormaPagtoDto dto)
        {
            try
            {
                FormaPagto formaPagto = new(dto);
                _repFormaPagto.SaveChanges(formaPagto);
                FormaPagtoView view = new(formaPagto);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao inserir forma de pagamento. Erro: {e.Message}");
            }
        }

        public FormaPagtoView Update(int id, FormaPagtoDto dto)
        {
            try
            {
                FormaPagto formaPagto = _repFormaPagto.FindById<FormaPagto>(id) ?? throw new Exception($"Não foi possivél encontrar a forma de pagamento de ID = {id}.");
                formaPagto = new FormaPagto().AtualizaFormaPagto(formaPagto, dto);
                _repFormaPagto.SaveChanges(formaPagto);
                FormaPagtoView view = new(formaPagto);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao alterar forma de pagamento. Erro: {e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _repFormaPagto.DeleteById<FormaPagto>(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar forma de pagamento. Erro: {e.Message}");
            }
        }

        public void Delete(List<int> ids)
        {
            try
            {
                _repFormaPagto.DeleteByIds<FormaPagto>(ids);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar forma de pagamento. Erro: {e.Message}");
            }
        }

        public FormaPagtoView FindById(int id)
        {
            try
            {
                FormaPagto formaPagto = _repFormaPagto.FindById<FormaPagto>(id) ?? throw new Exception($"Não foi possivél encontrar o forma de pagamento de ID = {id}.");
                FormaPagtoView view = new(formaPagto);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar forma de pagamento. Erro: {e.Message}");
            }
        }

        public List<FormaPagtoView> FindAll()
        {
            try
            {
                List<FormaPagto> formaPagtoes = _repFormaPagto.FindAll<FormaPagto>();
                List<FormaPagtoView> view = new FormaPagtoView().ListFormaPagtoView(formaPagtoes);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar forma de pagamento. Erro: {e.Message}");
            }
        }
    }
}