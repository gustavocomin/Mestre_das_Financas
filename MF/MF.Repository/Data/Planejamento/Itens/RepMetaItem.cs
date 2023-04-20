using MF.Domain.Planejamento.Itens;
using MF.Repository.Commons;
using MF.Repository.Configurations.Db;

namespace MF.Repository.Data.Planejamento.Itens
{
    public class RepMetaItem : Rep<MetaItem>, IRepMetaItem
    {
        public RepMetaItem(DataContext contexto) : base(contexto)
        {
        }
    }
}