using MF.Domain.Commons.ClassesBase;
using MF.Domain.Commons.ModalidadePagto.CondPagtos.Parcs;

namespace MF.Domain.Commons.ModalidadePagto.CondPagtos
{
    public class CondPagto : IdBase
    {
        public string Descricao { get; set; }
        public bool Credito { get; set; }
        public int QuantParc { get; set; }

        public List<CondPagtoParcs>? Parcs { get; set; }
    }
}