using MF.Domain.Commons;

namespace MF.Domain.ControleMensal.Mercado.Itens
{
    public interface IRepItem : IRep<Item>
    {
        List<Item> BuscarItemLikeNome(string nome);
    }
}