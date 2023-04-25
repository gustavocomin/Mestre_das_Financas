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
using MF.Domain.ControleMensal.Rendas;
using MF.Domain.Planejamento;
using MF.Domain.Planejamento.Itens;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace MF.Repository.Configurations.Db
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
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
        public DbSet<Item> Item { get; set; }

        public DbSet<Meta> Meta { get; set; }
        public DbSet<MetaItem> MetaItem { get; set; }

        public bool TestarConexao()
        {
            return Database.CanConnect();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(@"E:\PROGRAMACAO\C#\Mestre das finanças - projeto de controle financeiro\Mestre_das_Financas\MF\MF.Api")
            .AddJsonFile("appsettings.json")
            .Build();

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Consumidor>();
            modelBuilder.Entity<Empresa>();
            modelBuilder.Entity<CondPagto>();
            modelBuilder.Entity<CondPagtoParcs>();
            modelBuilder.Entity<FormaPagto>();
            modelBuilder.Entity<Despesa>();
            modelBuilder.Entity<Renda>();
            modelBuilder.Entity<DescontoItem>();
            modelBuilder.Entity<ItemCompra>();
            modelBuilder.Entity<Compra>();
            modelBuilder.Entity<MarcaItem>();
            modelBuilder.Entity<Item>();
            modelBuilder.Entity<Meta>();
            modelBuilder.Entity<MetaItem>();

            modelBuilder.Entity<ItemCompra>()
                .HasOne(p => p.DescontoItem)
                .WithOne(e => e.ItemCompra)
                .HasForeignKey<DescontoItem>(e => e.CodigoItemCompra);
        }
    }
}