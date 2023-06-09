﻿using HtmlAgilityPack;
using MF.Application.ControleMensal.Mercado.Itens;
using MF.Domain.ControleMensal.Mercado.Compras.Itens;
using MF.Domain.ControleMensal.Mercado.Compras.Itens.Models;
using MF.Domain.ControleMensal.Mercado.Itens;
using MF.Domain.ControleMensal.Mercado.Itens.Models;

namespace MF.Application.ControleMensal.Mercado.Compras.Itens
{
    public class AplicItemCompra : IAplicItemCompra
    {
        private readonly IRepItemCompra _repItemCompra;
        private readonly IRepItem _repItem;
        private readonly IAplicItem _aplicItem;

        public AplicItemCompra(IRepItemCompra repItemCompra, IRepItem repItem, IAplicItem aplicItem)
        {
            _repItemCompra = repItemCompra;
            _repItem = repItem;
            _aplicItem = aplicItem;
        }

        public ItemCompraView Insert(ItemCompraDto dto)
        {
            try
            {
                ItemCompra ItemCompra = new(dto);
                _repItemCompra.SaveChanges(ItemCompra);
                ItemCompraView view = new(ItemCompra);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao inserir item na compra. Erro: {e.Message}");
            }
        }

        public ItemCompraView Update(int id, ItemCompraDto dto)
        {
            try
            {
                ItemCompra itemCompra = _repItemCompra.FindById<ItemCompra>(id) ?? throw new Exception($"Não foi possivél encontrar o item da compra de ID = {id} - Id da compra = {dto.CodigoCompra}.");
                itemCompra = new ItemCompra().AtualizaItemCompra(itemCompra, dto);
                _repItemCompra.SaveChanges(itemCompra);
                ItemCompraView view = new(itemCompra);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao alterar item da compra. Erro: {e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _repItemCompra.DeleteById<ItemCompra>(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar item da compra. Erro: {e.Message}");
            }
        }

        public void Delete(List<int> ids)
        {
            try
            {
                _repItemCompra.DeleteByIds<ItemCompra>(ids);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar item da compra. Erro: {e.Message}");
            }
        }

        public ItemCompraView FindById(int id)
        {
            try
            {
                ItemCompra itemCompra = _repItemCompra.FindById<ItemCompra>(id) ?? throw new Exception($"Não foi possivél encontrar o item da compra de ID = {id}.");
                ItemCompraView view = new(itemCompra);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar item da compra. Erro: {e.Message}");
            }
        }

        public List<ItemCompraView> FindAll()
        {
            try
            {
                List<ItemCompra> itemCompraes = _repItemCompra.FindAll<ItemCompra>();
                List<ItemCompraView> view = new ItemCompraView().ListItemCompraView(itemCompraes);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar item da compra. Erro: {e.Message}");
            }
        }

        public List<ItemCompra> ImportarItensNFCE(HtmlNodeCollection tdNodes, int id)
        {
            List<ItemCompra> itens = new();
            if (tdNodes != null)
            {
                ItemCompra item = null;
                for (int i = 0; i < tdNodes.Count; i++)
                {
                    HtmlNode tdNode = tdNodes[i];
                    HtmlNode spanNode = tdNode.SelectSingleNode("./span");

                    if (i % 6 == 0 && spanNode != null)
                    {
                        item = new ItemCompra
                        {
                            CodigoCompra = id
                        };

                        itens.Add(item);
                    }

                    if (spanNode != null)
                    {
                        string spanText = spanNode.InnerText.Trim();

                        switch (i % 6)
                        {
                            case 0:
                                item.SequencialItem = int.Parse(spanText);
                                break;
                            case 1:
                                item.Descricao = spanText;
                                break;
                            case 2:
                                item.Quantidade = decimal.Parse(spanText);
                                break;
                            case 3:
                                item.UnidadeCompra = (UnidadeCompra)Enum.Parse(typeof(UnidadeCompra), spanText.ToUpper().Trim());
                                break;
                            case 4:
                                item.ValorUnitario = decimal.Parse(spanText);
                                break;
                            case 5:
                                item.ValorTotalItem = decimal.Parse(spanText);
                                break;

                        }
                    }
                }
            }

            List<ItemCompra> itensInexistens = CriaListaItensInexistes(itens);
            if (itensInexistens.Count > 0)
            {
                List<ItemDto> dtos = new ItemDto().CriaListaDto(itensInexistens.Select(x => x.Descricao).ToList());
                _aplicItem.Insert(dtos);
            }
            _repItemCompra.SaveChangesRange(itens);
            return itens;
        }

        public List<ItemCompra> CriaListaItensInexistes(List<ItemCompra> itens)
        {
            List<ItemCompra> itensInexistens = new();

            itens.ForEach(x =>
            {
                List<Item> itensExistentes = _repItem.BuscarItemLikeNome(x.Descricao);

                if (itensExistentes != null && !itensExistentes.Any())
                    itensInexistens.Add(x);
            });

            return itensInexistens;
        }
    }
}