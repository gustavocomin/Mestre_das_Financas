using MF.Domain.ControleMensal.Mercado.Itens;
using MF.Repository.Commons;
using MF.Repository.Configurations.Db;

namespace MF.Repository.Data.ControleMensal.Mercado.Itens
{
    public class RepItem : Rep<Item>, IRepItem
    {

        private readonly DataContext _contexto;

        public RepItem(DataContext contexto) : base(contexto)
        {

            _contexto = contexto;
        }

        public List<Item> BuscarItemLikeNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
                throw new Exception($"Nome inválido! Revise e tente novamente. NOME: {nome}");

            List<Item> list = _contexto.Set<Item>().Where(x => x.Descricao.ToUpper().Contains(nome.ToUpper())).ToList();

            return list;
        }
    }
}