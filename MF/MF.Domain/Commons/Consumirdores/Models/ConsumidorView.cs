using MF.Domain.Commons.ClassesBase;
using MF.Domain.ControleMensal.Despesas.Models;
using MF.Domain.ControleMensal.Rendas.Models;

namespace MF.Domain.Commons.Consumirdores.Models
{
    public class ConsumidorView : IdBaseDtAlt
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime? DataNascimento { get; set; }
        public decimal RendaTotal { get; set; } = 0;
        public string? Celular { get; set; }

        public List<RendaView> Rendas { get; set; }
        public List<DespesaView> Despesas { get; set; }

        public ConsumidorView()
        {
        }

        public ConsumidorView(Consumidor consumidor)
        {
            Id = consumidor.Id;
            Nome = consumidor.Nome;
            Email = consumidor.Email;
            DataNascimento = consumidor.DataNascimento;
            RendaTotal = consumidor.RendaTotal;
            Celular = consumidor.Celular;
            Rendas = new RendaView().ListRendaView(consumidor.Rendas);
            Despesas = new DespesaView().ListDespesaView(consumidor.Despesas);
        }

        public List<ConsumidorView> ListConsumidorView(List<Consumidor> consumidores)
        {
            List<ConsumidorView> list = new();
            consumidores.ForEach(con =>
            {
                list.Add(new ConsumidorView(con));
            });
            return list;
        }
    }
}