using MF.Domain.Commons.ClassesBase;

namespace MF.Domain.Commons.ModalidadePagto.CondPagtos.Parcs
{
    public class CondPagtoParcs : IdBase
    {
        public int CodigoCondPagto { get; private set; }
        public decimal ValorParc { get; private set; }
        public int SeqParc { get; private set; }

        public List<CondPagtoParcs> GerarParcelas(decimal valorTotal, decimal quantParc)
        {
            List<CondPagtoParcs> Parcs = new();

            decimal valorParc = Math.Round(valorTotal / quantParc, 2, MidpointRounding.ToEven);
            int count = 1;

            for (int i = 0; i < quantParc; i++)
            {
                Parcs.Add(new CondPagtoParcs
                {
                    CodigoCondPagto = Id,
                    SeqParc = count,
                    ValorParc = valorParc
                });
                count++;
            }

            return Parcs;
        }
    }
}