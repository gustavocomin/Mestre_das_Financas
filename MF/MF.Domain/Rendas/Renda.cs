using MF.Domain.Commons;
using MF.Domain.Consumirdores;
using MF.Domain.Empresas;

namespace MF.Domain.Rendas
{
    public class Renda
    {
        public Renda()
        {
            DataAlteracao = DateTime.Now;
            Common.AtualizaDataAlteracao<Renda>(this);
        }

        public int Id { get; set; }
        public int Descricao { get; set; }
        public decimal Valor { get; set; }
        public int CodigoConsumidor { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int CodigoEmpresa { get; set; }

        public virtual Empresa? Empresa { get; set; }
        public virtual Consumidor Consumidor { get; set; }
    }
}