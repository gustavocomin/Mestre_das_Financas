using MF.Domain.Commons.ClassesBase;
using MF.Domain.Commons.Consumirdores.Models;
using MF.Domain.Commons.Empresas.Models;

namespace MF.Domain.ControleMensal.Rendas.Models
{
    public class RendaView : IdBaseDtAlt
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public bool Salario { get; set; }

        public int? CodigoEmpresa { get; set; }
        public int? CodigoConsumidor { get; set; }

        public virtual EmpresaView Empresa { get; set; }
        public virtual ConsumidorView Consumidor { get; set; }

        public RendaView()
        {
        }

        public RendaView(Renda renda)
        {
            Id = renda.Id;
            Descricao = renda.Descricao;
            Valor = renda.Valor;
            Salario = renda.Salario;
            CodigoEmpresa = renda.CodigoEmpresa;
            CodigoConsumidor = renda.CodigoConsumidor;
            Empresa = new EmpresaView(renda.Empresa);
            Consumidor = new ConsumidorView(renda.Consumidor);
        }

        public List<RendaView> ListRendaView(List<Renda> rendas)
        {
            List<RendaView> list = new();
            rendas.ForEach(x =>
            {
                rendas.Add(x);
            });

            return list;
        }
    }
}