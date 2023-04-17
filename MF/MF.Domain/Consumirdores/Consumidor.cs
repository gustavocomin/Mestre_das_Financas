using MF.Domain.Commons;
using MF.Domain.Despesas;
using MF.Domain.Rendas;

namespace MF.Domain.Consumirdores
{
    public class Consumidor
    {
        public Consumidor()
        {
            AtualizaRenda();
            Common.AtualizaDataAlteracao<Consumidor>(this);
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime? DataNascimento { get; set; }
        private DateTime DataAlteracao { get; set; } = DateTime.Now;
        public decimal RendaTotal { get; set; }

        public virtual List<Renda>? Rendas { get; set; }
        public virtual List<Despesa>? Despesas { get; set; }


        private void AtualizaRenda()
        {
            RendaTotal = Rendas?.Sum(x => x.Valor) ?? 0;
        }
    }
}