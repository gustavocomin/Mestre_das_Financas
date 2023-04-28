using MF.Domain.Commons.ClassesBase;
using MF.Domain.Commons.Empresas;
using MF.Domain.Commons.ModalidadePagto.CondPagtos;
using MF.Domain.Commons.ModalidadePagto.FormaPagtos;
using MF.Domain.ControleMensal.Mercado.Compras.Itens;
using MF.Domain.ControleMensal.Mercado.Compras.Models;

namespace MF.Domain.ControleMensal.Mercado.Compras
{
    public class Compra : IdBase
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

        public Empresa? Empresa { get; set; }
        public FormaPagto? FormaPagto { get; set; }
        public CondPagto? CondPagto { get; set; }
        public List<ItemCompra>? Itens { get; set; }

        private void CalculaValorTotalDescontos()
        {
            ValorTotalDescontos = Itens.Sum(x => x.DescontoItem.ValorDesconto > 0 ? x.DescontoItem.ValorDesconto : 0);
        }

        private void CalculaValorTotalItens()
        {
            ValorTotalItens = Itens.Sum(x => x.ValorTotalItem);
        }

        private void CalculaValorTotal()
        {
            ValidaValorTotalItens(ValorTotalItens);
            ValorTotal = ValorTotalItens - ValorTotalDescontos + ValorTributos;
        }

        public void AtualizaCalculos()
        {
            CalculaValorTotalDescontos();
            CalculaValorTotalItens();
            CalculaValorTotal();
        }

        private static void ValidaValorTotalItens(decimal valorTotalItens)
        {
            if (string.IsNullOrWhiteSpace(valorTotalItens.ToString()))
                throw new Exception("Erro ao calcular valor total! Erro ao calcular o valor total dos itens.");
        }

        public Compra()
        {
        }

        public Compra(CompraDto compraDto)
        {
            Descricao = compraDto.Descricao;
            DataCompra = compraDto.DataCompra;
            ValorTributos = compraDto.ValorTributos;
            COO = compraDto.COO;
            CCF = compraDto.CCF;
            CodigoFormaPagto = compraDto.CodigoFormaPagto;
            CodigoCondPagto = compraDto.CodigoCondPagto;
            CodigoEmpresa = compraDto.CodigoEmpresa;
            AtualizaCalculos();
        }

        public Compra AtualizaCompra(Compra compra, CompraDto compraDto)
        {
            compra.Descricao = compraDto.Descricao;
            compra.DataCompra = compraDto.DataCompra;
            compra.ValorTributos = compraDto.ValorTributos;
            compra.COO = compraDto.COO;
            compra.CCF = compraDto.CCF;
            compra.CodigoFormaPagto = compraDto.CodigoFormaPagto;
            compra.CodigoCondPagto = compraDto.CodigoCondPagto;
            compra.CodigoEmpresa = compraDto.CodigoEmpresa;
            AtualizaCalculos();

            return compra;
        }
    }
}