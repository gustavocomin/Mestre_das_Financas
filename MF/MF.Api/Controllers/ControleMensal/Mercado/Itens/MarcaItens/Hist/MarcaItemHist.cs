using MF.Domain.Commons.ClassesBase;
using MF.Domain.Commons.Empresas;

namespace MF.Domain.ControleMensal.Mercado.Itens.MarcaItens.Hist
{
    public class MarcaItemHist : IdBaseDtAlt
    {
        public decimal ValorUnitCompra { get; set; }

        public int CodigoEmpresa { get; set; }
        public int CodigoMarcaItem { get; set; }


        public Lazy<MarcaItem> MarcaItem { get; set; }
        public Lazy<Empresa> Empresa { get; set; }
    }
}