using MF.Domain.Commons.FuncoesBase;

namespace MF.Domain.Commons.ClassesBase
{
    public class IdBaseDtAlt
    {
        public IdBaseDtAlt()
        {
            Common.AtualizaDataAlteracao<IdBaseDtAlt>(this);
        }

        private DateTime DataAlteracao { get; set; } = DateTime.Now;
    }
}