using System.Text.RegularExpressions;

namespace MF.Domain.Commons.Functions
{
    public class CommonFunctions
    {
        public static string RemoveCaracterEspecial(string texto)
        {
            return Regex.Replace(texto, @"[^a-zA-Z0-9]", "");
        }
    }
}