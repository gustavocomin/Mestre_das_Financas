using MF.Domain.Commons.ClassesBase;
using MF.Domain.Commons.ModalidadePagto.CondPagtos.Parcs.Models;
using System.ComponentModel;

namespace MF.Domain.Commons.ModalidadePagto.CondPagtos.Parcs
{
    public class CondPagtoParcs : IdBase
    {
        public int CodigoOrigem { get; set; }
        public OrigemCongPagtoParc Origem { get; set; }
        public int CodigoCondPagto { get; private set; }
        public decimal ValorParc { get; private set; }
        public int SeqParc { get; private set; }

        public CondPagtoParcs()
        {
        }

        public List<CondPagtoParcs> GerarParcelas(CondPagtoParcsDto condPagtoParcs)
        {
            List<CondPagtoParcs> Parcs = new();

            decimal valorParc = Math.Round(condPagtoParcs.ValorTotal / condPagtoParcs.QuantParc, 2, MidpointRounding.ToEven);
            int count = 1;

            for (int i = 0; i < condPagtoParcs.QuantParc; i++)
            {
                Parcs.Add(new CondPagtoParcs
                {
                    CodigoCondPagto = condPagtoParcs.CodigoCondPagto,
                    SeqParc = count,
                    ValorParc = valorParc,
                    CodigoOrigem = condPagtoParcs.CodigoOrigem,
                    Origem = condPagtoParcs.Origem
                });
                count++;
            }

            return Parcs;
        }
    }

    public enum OrigemCongPagtoParc
    {
        [Description("Despesa ")]
        Despesa = 0,
    }
}