using System.Reflection;

namespace MF.Domain.Commons.FuncoesBase
{
    public class Common
    {
        public static void AtualizaDataAlteracao<T>(object obj)
        {
            Type tipo = obj.GetType();
            PropertyInfo propriedadeDataAlteracao = tipo.GetProperty("DataAlteracao");

            if (propriedadeDataAlteracao != null && propriedadeDataAlteracao.PropertyType == typeof(DateTime))
                propriedadeDataAlteracao.SetValue(obj, DateTime.Now);
            else
                throw new ArgumentException("O objeto fornecido não possui uma propriedade 'DataAlteracao' do tipo 'DateTime'.");
        }
    }
}