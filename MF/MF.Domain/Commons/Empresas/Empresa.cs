using MF.Domain.Commons.ClassesBase;
using MF.Domain.Commons.Empresas.Models;

namespace MF.Domain.Commons.Empresas
{
    public class Empresa : IdBase
    {
        public string NomeEmpresa { get; set; } = "";
        public string? CnpjEmpresa { get; set; }
        public string? Endereço { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Complemento { get; set; }

        public Empresa()
        {
        }

        public Empresa(EmpresaDto empresa)
        {
            NomeEmpresa = empresa.NomeEmpresa;
            CnpjEmpresa = empresa.CnpjEmpresa;
            Endereço = empresa.Endereço;
            Bairro = empresa.Bairro;
            Cidade = empresa.Cidade;
            Complemento = empresa.Complemento;
        }
    }
}