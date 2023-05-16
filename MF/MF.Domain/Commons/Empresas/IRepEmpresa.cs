namespace MF.Domain.Commons.Empresas
{
    public interface IRepEmpresa : IRep<Empresa>
    {
        List<Empresa> BuscarEmpresaPorNomeOuCNPJ(string cnpjEmpresa, string nomeEmpresa);
    }
}