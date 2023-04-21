using MF.Domain.Commons.ClassesBase;
using MF.Domain.ControleMensal.Despesas;

namespace MF.Domain.Commons.Consumirdores
{
    public class Consumidor : IdBaseDtAlt
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime? DataNascimento { get; set; }
        public decimal RendaTotal { get; private set; } = 0;
        public string? Celular { get; set; }

        public List<Renda> Rendas { get; set; }
        public List<Despesa> Despesas { get; set; }

        public void AtualizaRenda()
        {
            RendaTotal = Rendas?.Sum(x => x.Valor) ?? 0;
        }
    }
}