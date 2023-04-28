using MF.Domain.Planejamento;
using MF.Domain.Planejamento.Models;

namespace MF.Application.Planejamento
{
    public class AplicMeta : IAplicMeta
    {

        private readonly IRepMeta _repMeta;

        public AplicMeta(IRepMeta repMeta)
        {
            _repMeta = repMeta;
        }

        public MetaView Insert(MetaDto dto)
        {
            try
            {
                Meta meta = new(dto);
                _repMeta.SaveChanges(meta);
                MetaView view = new(meta);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao inserir meta. Erro: {e.Message}");
            }
        }

        public MetaView Update(int id, MetaDto dto)
        {
            try
            {
                Meta meta = _repMeta.FindById<Meta>(id) ?? throw new Exception($"Não foi possivél encontrar meta de ID = {id}.");
                meta = new Meta().AtualizaMeta(meta, dto);
                _repMeta.SaveChanges(meta);
                MetaView view = new(meta);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao alterar meta. Erro: {e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _repMeta.DeleteById<Meta>(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar meta. Erro: {e.Message}");
            }
        }

        public void Delete(List<int> ids)
        {
            try
            {
                _repMeta.DeleteByIds<Meta>(ids);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar metas. Erro: {e.Message}");
            }
        }

        public MetaView FindById(int id)
        {
            try
            {
                Meta meta = _repMeta.FindById<Meta>(id) ?? throw new Exception($"Não foi possivél encontrar meta de ID = {id}.");
                MetaView view = new(meta);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar meta. Erro: {e.Message}");
            }
        }

        public List<MetaView> FindAll()
        {
            try
            {
                List<Meta> metaItens = _repMeta.FindAll<Meta>();
                List<MetaView> view = new MetaView().ListMetaView(metaItens);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar metas. Erro: {e.Message}");
            }
        }
    }
}