using MF.Domain.Commons.ModalidadePagto.CondPagtos.Parcs;
using MF.Domain.Commons.ModalidadePagto.CondPagtos.Parcs.Models;

namespace MF.Application.Commons.ModalidadePagto.CondPagtos.Parcs
{
    public class AplicCondPagtoParcs : IAplicCondPagtoParcs
    {
        private readonly IRepCondPagtoParcs _repCondPagtoParcs;

        public AplicCondPagtoParcs(IRepCondPagtoParcs repCondPagtoParcs)
        {
            _repCondPagtoParcs = repCondPagtoParcs;
        }

        public List<CondPagtoParcsView> Insert(CondPagtoParcsDto dto)
        {
            try
            {
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
    }
}