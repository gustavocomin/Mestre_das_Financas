using MF.Domain.Commons.FuncoesBase;

namespace MF.Domain.Commons.ClassesBase
{
    public class IdBaseDtAlt : IdBase
    {
        public IdBaseDtAlt()
        {
            Common.AtualizaDataAlteracao<IdBaseDtAlt>(this);
        }

        public DateTime DataAlteracao { get; private set; } = DateTime.Now;
    }
}