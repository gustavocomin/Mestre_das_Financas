using MF.Domain.Commons.ClassesBase;
using MF.Domain.Commons.Empresas;

namespace MF.Domain.ControleMensal.Mercado.Itens.MarcaItens.Hist
{
    public class MarcaItemHist : IdBaseDtAlt
    {
        public decimal ValorUnitCompra { get; set; }

        public int CodigoEmpresa { get; set; }
        public int CodigoMarcaItem { get; set; }


        public MarcaItem MarcaItem { get; set; }
        public Empresa Empresa { get; set; }
    }
}