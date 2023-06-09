﻿using MF.Domain.Planejamento.Itens;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Data.Planejamento.Itens
{
    public class MetaItemConfig : IEntityTypeConfiguration<MetaItem>
    {
        public void Configure(EntityTypeBuilder<MetaItem> builder)
        {
            builder.ToTable("METAITEM");

            string idColumnName = $"Id{builder.Metadata.ClrType.Name}";

            builder.HasKey(mi => mi.Id);

            builder.Property(t => t.Id)
                   .HasColumnName(idColumnName);

            builder.Property(mi => mi.DataAlteracao)
                   .HasColumnType("TIMESTAMP")
                   .IsRequired();

            builder.Property(mi => mi.Descricao)
                   .HasColumnType("varchar")
                   .HasMaxLength(200)
                   .IsRequired();

            builder.Property(mi => mi.ValorCompra)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(mi => mi.LinkCompra)
                   .HasColumnType("varchar")
                   .HasMaxLength(900);

            builder.Property(mi => mi.ValorReservaCompra)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(mi => mi.DiferencaCompraReserva)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(mi => mi.DataExpectativaAquisicao)
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(mi => mi.ValorGuardarMes)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(mi => mi.Status)
                   .IsRequired();

            builder.Property(mi => mi.CodigoMeta)
                   .HasColumnType("INT")
                   .IsRequired();

            builder.HasOne(mi => mi.Meta)
                   .WithMany(m => m.Itens)
                   .HasForeignKey(mi => mi.CodigoMeta)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}




