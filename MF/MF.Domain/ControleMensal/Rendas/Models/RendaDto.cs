namespace MF.Domain.ControleMensal.Rendas.Models
{
    public class RendaDto
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public bool Salario { get; set; }

        public int? CodigoEmpresa { get; set; }
        public int? CodigoConsumidor { get; set; }
    }
}