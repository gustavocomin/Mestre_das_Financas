using MF.Domain.Commons.ClassesBase;
using MF.Domain.Commons.Consumirdores;
using MF.Domain.Commons.Empresas;

namespace MF.Domain.ControleMensal.Rendas
{
    public class Renda : IdBaseDtAlt
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public bool Salario { get; set; }

        public int? CodigoEmpresa { get; set; }
        public int? CodigoConsumidor { get; set; }

        public virtual Empresa Empresa { get; set; }
        public virtual Consumidor Consumidor { get; set; }
    }
}