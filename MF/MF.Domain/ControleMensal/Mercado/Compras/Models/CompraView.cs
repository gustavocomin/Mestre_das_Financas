using MF.Domain.Commons.ClassesBase;
using MF.Domain.Commons.Empresas.Models;
using MF.Domain.Commons.ModalidadePagto.CondPagtos.Models;
using MF.Domain.Commons.ModalidadePagto.FormaPagtos.Models;
using MF.Domain.ControleMensal.Mercado.Compras.Itens.Models;

namespace MF.Domain.ControleMensal.Mercado.Compras.Models
{
    public class CompraView : IdBase
    {
        public string Descricao { get; set; }
        public DateTime DataCompra { get; set; }
        public decimal ValorTotal { get; private set; }
        public decimal ValorTotalItens { get; private set; }
        public decimal ValorTotalDescontos { get; private set; }
        public decimal ValorTributos { get; set; }
        public string? COO { get; set; }
        public string? CCF { get; set; }

        public int? CodigoFormaPagto { get; set; }
        public int? CodigoCondPagto { get; set; }
        public int? CodigoEmpresa { get; set; }

        public EmpresaView? Empresa { get; set; }
        public FormaPagtoView? FormaPagto { get; set; }
        public CondPagtoView? CondPagto { get; set; }
        public List<ItemCompraView>? Itens { get; set; }

        public CompraView()
        {
        }

        public CompraView(Compra compra)
        {
            Descricao = compra.Descricao;
            DataCompra = compra.DataCompra;
            ValorTotal = compra.ValorTotal;
            ValorTotalItens = compra.ValorTotalItens;
            ValorTotalDescontos = compra.ValorTotalDescontos;
            ValorTributos = compra.ValorTributos;
            COO = compra.COO;
            CCF = compra.CCF;
            CodigoFormaPagto = compra.CodigoFormaPagto;
            CodigoCondPagto = compra.CodigoCondPagto;
            CodigoEmpresa = compra.CodigoEmpresa;
            Empresa = compra.Empresa == null ? null : new EmpresaView(compra.Empresa);
            FormaPagto = compra.FormaPagto == null ? null : new FormaPagtoView(compra.FormaPagto);
            CondPagto = compra.CondPagto == null ? null : new CondPagtoView(compra.CondPagto);
            Itens = (compra.Itens != null && compra.Itens.Count > 0) ? new ItemCompraView().ListItemCompraView(compra.Itens) : null;
        }

        public List<CompraView> ListCompraView(List<Compra> compras)
        {
            List<CompraView> list = new();
            compras.ForEach(x =>
            {
                list.Add(new CompraView(x));
            });
            return list;
        }
    }
}