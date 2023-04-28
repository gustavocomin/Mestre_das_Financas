using System.Reflection;

namespace MF.Domain.Commons.ClassesBase
{
    public class IdBaseDtAlt : IdBase
    {
        public IdBaseDtAlt()
        {
            AtualizaDataAlteracao<IdBaseDtAlt>(this);
        }

        public DateTime DataAlteracao { get; protected set; } = DateTime.Now;

        protected void AtualizaDataAlteracao<T>(object obj)
        {
            Type tipo = obj.GetType();
            PropertyInfo propriedadeDataAlteracao = tipo.GetProperty("DataAlteracao");

            try
            {
                if (propriedadeDataAlteracao != null && propriedadeDataAlteracao.PropertyType == typeof(DateTime))
                    propriedadeDataAlteracao.SetValue(obj, DateTime.Now);
            }
            catch (Exception e)
            {
                throw new ArgumentException("O objeto fornecido não possui uma propriedade 'DataAlteracao' do tipo 'DateTime'." + e.Message + e.InnerException);
            }
        }
    }
}