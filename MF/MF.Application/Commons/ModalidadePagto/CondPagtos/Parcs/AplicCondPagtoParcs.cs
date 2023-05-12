using MF.Domain.Commons.ModalidadePagto.CondPagtos;
using MF.Domain.Commons.ModalidadePagto.CondPagtos.Parcs;
using MF.Domain.Commons.ModalidadePagto.CondPagtos.Parcs.Models;
using MF.Domain.ControleMensal.Despesas;

namespace MF.Application.Commons.ModalidadePagto.CondPagtos.Parcs
{
    public class AplicCondPagtoParcs : IAplicCondPagtoParcs
    {
        private readonly IRepCondPagtoParcs _repCondPagtoParcs;
        private readonly IRepCondPagto _repCondPagto;
        private readonly IRepDespesa _repDespesa;

        public AplicCondPagtoParcs(IRepCondPagtoParcs repCondPagtoParcs,
                                   IRepCondPagto repCondPagto,
                                   IRepDespesa repDespesa)
        {
            _repCondPagtoParcs = repCondPagtoParcs;
            _repCondPagto = repCondPagto;
            _repDespesa = repDespesa;
        }

        public List<CondPagtoParcsView> Insert(CondPagtoParcsDto dto)
        {
            try
            {
                ValidaCondPagto(dto.CodigoCondPagto);
                ValidaOrigem(dto.CodigoOrigem);
                List<CondPagtoParcs> parcs = new CondPagtoParcs().GerarParcelas(dto);
                _repCondPagtoParcs.SaveChanges(parcs);
                List<CondPagtoParcsView> view = new CondPagtoParcsView().ListCondPagtoParcsView(parcs);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao inserir parcelas. Erro: {e.Message}");
            }
        }

        public List<CondPagtoParcsView> Update(int idCondPagto, CondPagtoParcsDto dto)
        {
            try
            {
                ValidaCondPagto(dto.CodigoCondPagto);
                ValidaOrigem(dto.CodigoOrigem);
                List<CondPagtoParcs> oldParcs = _repCondPagtoParcs.FindAll<CondPagtoParcs>().Where(x => x.CodigoCondPagto == idCondPagto).ToList();
                List<int> idsOldParcs = oldParcs.Select(x => x.Id).ToList();
                Delete(idsOldParcs);
                List<CondPagtoParcs> parcs = new CondPagtoParcs().GerarParcelas(dto);
                _repCondPagtoParcs.SaveChanges(parcs);
                List<CondPagtoParcsView> view = new CondPagtoParcsView().ListCondPagtoParcsView(parcs);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao alterar parcelas. Erro: {e.Message}");
            }
        }

        public void Delete(List<int> ids)
        {
            try
            {
                _repCondPagtoParcs.DeleteByIds<CondPagtoParcs>(ids);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar parcelas. Erro: {e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _repCondPagtoParcs.DeleteById<CondPagtoParcs>(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar parcelas. Erro: {e.Message}");
            }
        }

        public List<CondPagtoParcsView> FindById(int idCondPagto)
        {
            try
            {
                List<CondPagtoParcs> parcs = _repCondPagtoParcs.FindAll<CondPagtoParcs>().Where(x => x.CodigoCondPagto == idCondPagto).ToList() ?? throw new Exception($"Não foi possivél encontrar o parcelas de ID = {idCondPagto}.");
                List<CondPagtoParcsView> view = new CondPagtoParcsView().ListCondPagtoParcsView(parcs);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar parcelas. Erro: {e.Message}");
            }
        }

        public List<CondPagtoParcsView> FindAll()
        {
            try
            {
                List<CondPagtoParcs> parcelases = _repCondPagtoParcs.FindAll<CondPagtoParcs>();
                List<CondPagtoParcsView> view = new CondPagtoParcsView().ListCondPagtoParcsView(parcelases);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar parcelases. Erro: {e.Message}");
            }
        }

        private void ValidaCondPagto(int codigoCondPagto)
        {
            CondPagto condPagto = _repCondPagto.FindById<CondPagto>(codigoCondPagto) ?? throw new Exception($"Condição de pagamento não encontrada para o Código: {codigoCondPagto}. Revise as informações e tente novamente.");
        }

        private void ValidaOrigem(int codigoOrigem)
        {
            Despesa despesa = _repDespesa.FindById<Despesa>(codigoOrigem) ?? throw new Exception($"Origem do parcelamento não encontra para o Código: {codigoOrigem}. Revise as informações e tente novamente.");
        }
    }
}