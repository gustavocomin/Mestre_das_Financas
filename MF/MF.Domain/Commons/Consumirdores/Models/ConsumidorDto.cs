namespace MF.Domain.Commons.Consumirdores.Models
{
    public class ConsumidorDto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string? Celular { get; set; }
    }
}