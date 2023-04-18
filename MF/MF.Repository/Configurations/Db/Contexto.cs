using MF.Domain.Commons.Consumirdores;
using MF.Domain.Commons.Empresas;
using MF.Domain.Commons.ModalidadePagto.CondPagtos;
using MF.Domain.Commons.ModalidadePagto.CondPagtos.Parcs;
using MF.Domain.Commons.ModalidadePagto.FormaPagtos;
using MF.Domain.ControleMensal.Despesas;
using MF.Domain.ControleMensal.Mercado.Compras;
using MF.Domain.ControleMensal.Mercado.Compras.Itens;
using MF.Domain.ControleMensal.Mercado.Compras.Itens.Desconto;
using MF.Domain.ControleMensal.Mercado.Itens;
using MF.Domain.ControleMensal.Mercado.Itens.MarcaItens;
using MF.Domain.ControleMensal.Mercado.Itens.MarcaItens.Hist;
using MF.Domain.ControleMensal.Rendas;
using MF.Domain.Planejamento;
using MF.Domain.Planejamento.Itens;
using Microsoft.EntityFrameworkCore;

namespace MF.Repository.Configurations.Db
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Consumidor> Consumidor { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<CondPagto> CondPagto { get; set; }
        public DbSet<CondPagtoParcs> CondPagtoParcs { get; set; }
        public DbSet<FormaPagto> FormaPagto { get; set; }

        public DbSet<Despesa> Despesa { get; set; }
        public DbSet<Renda> Renda { get; set; }

        public DbSet<DescontoItem> DescontoItem { get; set; }
        public DbSet<ItemCompra> ItemCompra { get; set; }
        public DbSet<Compra> Compra { get; set; }
        public DbSet<MarcaItem> MarcaItem { get; set; }
        public DbSet<MarcaItemHist> MarcaItemHist { get; set; }
        public DbSet<Item> Item { get; set; }

        public DbSet<Meta> Meta { get; set; }
        public DbSet<MetaItem> MetaItem { get; set; }
    }
}