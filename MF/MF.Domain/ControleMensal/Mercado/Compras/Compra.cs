﻿using MF.Domain.Commons.Empresas;
using MF.Domain.Commons.ModalidadePagto.CondPagtos;
using MF.Domain.Commons.ModalidadePagto.FormaPagtos;

namespace MF.Domain.ControleMensal.Mercado.Compras
{
    public class Compra
    {
        public string Descricao { get; set; }
        public DateTime? DataCompra { get; set; }
        public decimal ValorTotal { get; private set; }
        public decimal ValorTotalItens { get; private set; }
        public decimal ValorTotalDescontos { get; private set; }
        public decimal ValorTributos { get; set; }

        public int CodigoFormaPagto { get; set; }
        public int CodigoCondPagto { get; set; }
        public int CodigoEmpresa { get; set; }

        public Lazy<Empresa>? Empresa { get; set; }
        public Lazy<FormaPagto>? FormaPagto { get; set; }
        public Lazy<CondPagto>? CondPagto { get; set; }
        public List<ItemCompra>? Itens { get; set; }

        public void CalculaValorTotalDescontos()
        {
            ValorTotalDescontos = Itens.Sum(x => x.Desconto.ValorDesconto > 0 ? x.Desconto.ValorDesconto : 0);
        }

        public void CalculaValorTotalItens()
        {
            ValorTotalItens = Itens.Sum(x => x.ValorTotalItem);
        }

        public void CalculaValorTotal()
        {
            ValidaValorTotalItens(ValorTotalItens);
            ValorTotal = ValorTotalItens - ValorTotalDescontos + ValorTributos;
        }

        private void ValidaValorTotalItens(decimal valorTotalItens)
        {
            if (string.IsNullOrWhiteSpace(valorTotalItens.ToString()))
                throw new Exception("Erro ao calcular valor total! Erro ao calcular o valor total dos itens.");
        }
    }
}