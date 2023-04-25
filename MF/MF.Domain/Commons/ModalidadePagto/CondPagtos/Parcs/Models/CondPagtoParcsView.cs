using MF.Domain.Commons.ClassesBase;

namespace MF.Domain.Commons.ModalidadePagto.CondPagtos.Parcs.Models
{
    public class CondPagtoParcsView : IdBase
    {
        public int CodigoCondPagto { get; set; }
        public decimal ValorParc { get; set; }
        public int SeqParc { get; set; }

        public CondPagtoParcsView()
        {
        }

        public CondPagtoParcsView(CondPagtoParcs condPagtoParcs)
        {
            Id = condPagtoParcs.Id;
            CodigoCondPagto = condPagtoParcs.CodigoCondPagto;
            ValorParc = condPagtoParcs.ValorParc;
            SeqParc = condPagtoParcs.SeqParc;
        }

        public List<CondPagtoParcsView> ListCondPagtoParcsView(List<CondPagtoParcs> condPagtoParcs)
        {
            List<CondPagtoParcsView> list = new();
            condPagtoParcs.ForEach(x =>
            {
                list.Add(new CondPagtoParcsView(x));
            });

            return list;
        }
    }
}