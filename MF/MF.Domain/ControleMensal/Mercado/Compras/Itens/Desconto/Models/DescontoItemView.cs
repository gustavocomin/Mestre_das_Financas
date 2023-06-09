﻿using MF.Domain.Commons.ClassesBase;
using MF.Domain.ControleMensal.Mercado.Compras.Itens.Models;

namespace MF.Domain.ControleMensal.Mercado.Compras.Itens.Desconto.Models
{
    public class DescontoItemView : IdBase
    {
        public int CodigoItemCompra { get; set; }

        public decimal ValorDesconto { get; set; }
        public ItemCompraView ItemCompra { get; set; }

        public DescontoItemView()
        {
        }

        public DescontoItemView(DescontoItem descontoItem)
        {
            Id = descontoItem.Id;
            CodigoItemCompra = descontoItem.CodigoItemCompra;
            ValorDesconto = descontoItem.ValorDesconto;
            ItemCompra = new ItemCompraView(descontoItem.ItemCompra);
        }

        public List<DescontoItemView> ListDescontoItemView(List<DescontoItem> descontoItens)
        {
            List<DescontoItemView> list = new();
            descontoItens.ForEach(x =>
            {
                list.Add(new DescontoItemView(x));
            });
            return list;
        }
    }
}