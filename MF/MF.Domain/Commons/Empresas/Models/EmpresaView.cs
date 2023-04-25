using MF.Domain.Commons.ClassesBase;

namespace MF.Domain.Commons.Empresas.Models
{
    public class EmpresaView : IdBase
    {
        public string NomeEmpresa { get; set; } = "";
        public string? CnpjEmpresa { get; set; }
        public string? Endereço { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Complemento { get; set; }

        public EmpresaView()
        {
        }

        public EmpresaView(Empresa empresa)
        {
            Id = empresa.Id;
            NomeEmpresa = empresa.NomeEmpresa;
            CnpjEmpresa = empresa.CnpjEmpresa;
            Endereço = empresa.Endereço;
            Bairro = empresa.Bairro;
            Cidade = empresa.Cidade;
            Complemento = empresa.Complemento;
        }

        public List<EmpresaView> ListEmpresaView(List<Empresa> empresas)
        {
            List<EmpresaView> list = new();
            empresas.ForEach(x =>
            {
                list.Add(new EmpresaView(x));
            });
            return list;
        }
    }
}