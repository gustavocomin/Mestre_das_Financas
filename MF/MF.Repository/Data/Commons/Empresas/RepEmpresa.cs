using MF.Domain.Commons.Empresas;
using MF.Repository.Commons;
using MF.Repository.Configurations.Db;

namespace MF.Repository.Data.Commons.Empresas
{
    public class RepEmpresa : Rep<Empresa>, IRepEmpresa
    {
        private readonly DataContext _contexto;

        public RepEmpresa(DataContext contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public List<Empresa> BuscarEmpresaPorNomeOuCNPJ(string cnpjEmpresa, string nomeEmpresa)
        {
            if (string.IsNullOrEmpty(cnpjEmpresa) && string.IsNullOrEmpty(nomeEmpresa))
                throw new Exception("Cnpj e nome inválidos! Revise e tente novamente.");

            List<Empresa> empresas = _contexto.Set<Empresa>()
                                              .Where(x => x.CnpjEmpresa.Contains(cnpjEmpresa) ||
                                                          x.NomeEmpresa.Contains(nomeEmpresa))
                                              .ToList();

            return empresas;
        }
    }
}