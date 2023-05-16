using MF.Domain.Commons.ClassesBase;
using MF.Domain.Commons.Empresas.Models;
using System.Text.RegularExpressions;

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

        public Empresa(string cnpjEmpresa, string nomeEmpresa)
        {
            CnpjEmpresa = RemoveCaracterEspecial(cnpjEmpresa);
            NomeEmpresa = nomeEmpresa;
        }

        public Empresa(EmpresaDto empresa)
        {
            NomeEmpresa = empresa.NomeEmpresa;
            CnpjEmpresa = RemoveCaracterEspecial(empresa.CnpjEmpresa);
            Endereço = empresa.Endereço;
            Bairro = empresa.Bairro;
            Cidade = empresa.Cidade;
            Complemento = empresa.Complemento;
        }

        public Empresa AtualizaEmpresa(Empresa empresa, EmpresaDto empresaDto)
        {
            empresa.NomeEmpresa = empresaDto.NomeEmpresa;
            empresa.CnpjEmpresa = RemoveCaracterEspecial(empresaDto.CnpjEmpresa);
            empresa.Endereço = empresaDto.Endereço;
            empresa.Bairro = empresaDto.Bairro;
            empresa.Cidade = empresaDto.Cidade;
            empresa.Complemento = empresaDto.Complemento;

            return empresa;
        }

        public static string RemoveCaracterEspecial(string cnpj)
        {
            return Regex.Replace(cnpj, @"[^a-zA-Z0-9]", "");
        }
    }
}