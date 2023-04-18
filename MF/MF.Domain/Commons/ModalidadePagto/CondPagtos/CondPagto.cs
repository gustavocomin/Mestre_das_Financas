using MF.Domain.Commons.ClassesBase;

namespace MF.Domain.Commons.ModalidadePagto.CondPagtos
{
    public class CondPagto : IdBase
    {
        public string Descricao { get; set; }
        public bool Credito { get; set; }
        public int QuantParc { get; set; }
    }
}