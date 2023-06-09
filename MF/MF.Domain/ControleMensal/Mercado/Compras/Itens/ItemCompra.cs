﻿using MF.Domain.Commons.ClassesBase;
using MF.Domain.ControleMensal.Mercado.Compras.Itens.Desconto;
using MF.Domain.ControleMensal.Mercado.Compras.Itens.Models;
using System.ComponentModel;

namespace MF.Domain.ControleMensal.Mercado.Compras.Itens
{
    public class ItemCompra : IdBaseDtAlt
    {
        public int CodigoCompra { get; set; }
        public int SequencialItem { get; set; }
        public string Descricao { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotalItem { get; set; }
        public int? CodigoDesconto { get; set; }
        public UnidadeCompra UnidadeCompra { get; set; }

        public DescontoItem? DescontoItem { get; set; }
        public Compra Compra { get; set; }

        public ItemCompra()
        {
        }

        public ItemCompra(ItemCompraDto itemCompra)
        {
            CodigoCompra = itemCompra.CodigoCompra;
            Descricao = itemCompra.Descricao;
            Quantidade = itemCompra.Quantidade;
            ValorUnitario = itemCompra.ValorUnitario;
            CalculaSeqItem();
            CalculaValorTotalItem();
        }

        public void CalculaValorTotalItem()
        {
            ValorTotalItem = ValorUnitario * Quantidade;
        }

        public void CalculaSeqItem()
        {
            var listaSeqs = Compra.Itens.Select(x => x.SequencialItem).ToList();

            ValorTotalItem = (listaSeqs == null || listaSeqs.Count == 0) ? 1 : listaSeqs.Max() + 1;
        }

        public ItemCompra AtualizaItemCompra(ItemCompra itemCompra, ItemCompraDto itemCompraDto)
        {
            itemCompra.CodigoCompra = itemCompraDto.CodigoCompra;
            itemCompra.SequencialItem = itemCompraDto.SequencialItem;
            itemCompra.Descricao = itemCompraDto.Descricao;
            itemCompra.Quantidade = itemCompraDto.Quantidade;
            itemCompra.ValorUnitario = itemCompraDto.ValorUnitario;
            CalculaValorTotalItem();

            return itemCompra;
        }
    }

    public enum UnidadeCompra
    {
        [Description("Kg")]
        KG = 0,
        [Description("Un")]
        UN = 1,
    }
}