namespace MF.Domain.Commons.Empresas.Models
{
    public class EmpresaDto
    {
        public string NomeEmpresa { get; set; } = "";
        public string? CnpjEmpresa { get; set; }
        public string? Endereço { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Complemento { get; set; }
    }
}