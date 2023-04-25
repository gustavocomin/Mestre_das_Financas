using MF.Domain.Commons.ClassesBase;
using MF.Domain.Commons.ModalidadePagto.CondPagtos.Parcs.Models;

namespace MF.Domain.Commons.ModalidadePagto.CondPagtos.Models
{
    public class CondPagtoView : IdBase
    {
        public string Descricao { get; set; }
        public bool Credito { get; set; }
        public int QuantParc { get; set; }

        public List<CondPagtoParcsView>? Parcs { get; set; }

        public CondPagtoView()
        {
        }

        public CondPagtoView(CondPagto condPagto)
        {
            Id = condPagto.Id;
            Descricao = condPagto.Descricao;
            Credito = condPagto.Credito;
            QuantParc = condPagto.QuantParc;
            Parcs = (condPagto.Parcs != null && condPagto.Parcs.Count > 0) ? new CondPagtoParcsView().ListCondPagtoParcsView(condPagto.Parcs) : null;
        }

        public List<CondPagtoView> ListCondPagtoView(List<CondPagto> condPagtos)
        {
            List<CondPagtoView> list = new();
            condPagtos.ForEach(condPagto =>
            {
                list.Add(new CondPagtoView(condPagto));
            });
            return list;
        }
    }
}