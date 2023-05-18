using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MF.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AjusteDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compra_CONDPAGTO_CondPagtoId",
                table: "Compra");

            migrationBuilder.DropForeignKey(
                name: "FK_Compra_EMPRESA_EmpresaId",
                table: "Compra");

            migrationBuilder.DropForeignKey(
                name: "FK_Compra_FORMAPAGTO_FormaPagtoId",
                table: "Compra");

            migrationBuilder.DropForeignKey(
                name: "FK_DescontoItem_ItemCompra_CodigoItemCompra",
                table: "DescontoItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemCompra_Compra_CompraId",
                table: "ItemCompra");

            migrationBuilder.DropForeignKey(
                name: "FK_MarcaItem_Item_ItemId",
                table: "MarcaItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Meta_Consumidor_ConsumidorId",
                table: "Meta");

            migrationBuilder.DropForeignKey(
                name: "FK_MetaItem_Meta_MetaId",
                table: "MetaItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MetaItem",
                table: "MetaItem");

            migrationBuilder.DropIndex(
                name: "IX_MetaItem_MetaId",
                table: "MetaItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Meta",
                table: "Meta");

            migrationBuilder.DropIndex(
                name: "IX_Meta_ConsumidorId",
                table: "Meta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MarcaItem",
                table: "MarcaItem");

            migrationBuilder.DropIndex(
                name: "IX_MarcaItem_ItemId",
                table: "MarcaItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemCompra",
                table: "ItemCompra");

            migrationBuilder.DropIndex(
                name: "IX_ItemCompra_CompraId",
                table: "ItemCompra");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DescontoItem",
                table: "DescontoItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Compra",
                table: "Compra");

            migrationBuilder.DropIndex(
                name: "IX_Compra_CondPagtoId",
                table: "Compra");

            migrationBuilder.DropIndex(
                name: "IX_Compra_EmpresaId",
                table: "Compra");

            migrationBuilder.DropIndex(
                name: "IX_Compra_FormaPagtoId",
                table: "Compra");

            migrationBuilder.DropColumn(
                name: "MetaId",
                table: "MetaItem");

            migrationBuilder.DropColumn(
                name: "ConsumidorId",
                table: "Meta");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "MarcaItem");

            migrationBuilder.DropColumn(
                name: "CompraId",
                table: "ItemCompra");

            migrationBuilder.DropColumn(
                name: "CondPagtoId",
                table: "Compra");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Compra");

            migrationBuilder.DropColumn(
                name: "FormaPagtoId",
                table: "Compra");

            migrationBuilder.RenameTable(
                name: "MetaItem",
                newName: "METAITEM");

            migrationBuilder.RenameTable(
                name: "Meta",
                newName: "META");

            migrationBuilder.RenameTable(
                name: "MarcaItem",
                newName: "MARCAITEM");

            migrationBuilder.RenameTable(
                name: "ItemCompra",
                newName: "ITEMCOMPRA");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "ITEM");

            migrationBuilder.RenameTable(
                name: "DescontoItem",
                newName: "DESCONTOITEM");

            migrationBuilder.RenameTable(
                name: "Compra",
                newName: "COMPRA");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "METAITEM",
                newName: "IdMetaItem");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "META",
                newName: "IdMeta");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MARCAITEM",
                newName: "IdMarcaItemView");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ITEMCOMPRA",
                newName: "IdItemCompra");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ITEM",
                newName: "IdItem");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DESCONTOITEM",
                newName: "IdDescontoItem");

            migrationBuilder.RenameIndex(
                name: "IX_DescontoItem_CodigoItemCompra",
                table: "DESCONTOITEM",
                newName: "IX_DESCONTOITEM_CodigoItemCompra");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "COMPRA",
                newName: "IdCompra");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorReservaCompra",
                table: "METAITEM",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorGuardarMes",
                table: "METAITEM",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorCompra",
                table: "METAITEM",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<string>(
                name: "LinkCompra",
                table: "METAITEM",
                type: "varchar",
                maxLength: 900,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DiferencaCompraReserva",
                table: "METAITEM",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "METAITEM",
                type: "varchar",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataExpectativaAquisicao",
                table: "METAITEM",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "METAITEM",
                type: "TIMESTAMP",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoMeta",
                table: "METAITEM",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotalGuardado",
                table: "META",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotalCompra",
                table: "META",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "META",
                type: "varchar",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataIniVigencia",
                table: "META",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataFimVigencia",
                table: "META",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "META",
                type: "TIMESTAMP",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "MARCAITEM",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "MARCAITEM",
                type: "TIMESTAMP",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoItem",
                table: "MARCAITEM",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "ItemViewId",
                table: "MARCAITEM",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorUnitario",
                table: "ITEMCOMPRA",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotalItem",
                table: "ITEMCOMPRA",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "SequencialItem",
                table: "ITEMCOMPRA",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "Quantidade",
                table: "ITEMCOMPRA",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "ITEMCOMPRA",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "ITEMCOMPRA",
                type: "TIMESTAMP",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoDesconto",
                table: "ITEMCOMPRA",
                type: "INT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CodigoCompra",
                table: "ITEMCOMPRA",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "ITEM",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorDesconto",
                table: "DESCONTOITEM",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoItemCompra",
                table: "DESCONTOITEM",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTributos",
                table: "COMPRA",
                type: "numeric(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotalNF",
                table: "COMPRA",
                type: "numeric(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotalItens",
                table: "COMPRA",
                type: "numeric(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotalDescontos",
                table: "COMPRA",
                type: "numeric(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotal",
                table: "COMPRA",
                type: "numeric(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<string>(
                name: "NumeroNF",
                table: "COMPRA",
                type: "VARCHAR",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "COMPRA",
                type: "VARCHAR",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCompra",
                table: "COMPRA",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoFormaPagto",
                table: "COMPRA",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CodigoEmpresa",
                table: "COMPRA",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CodigoCondPagto",
                table: "COMPRA",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "COO",
                table: "COMPRA",
                type: "VARCHAR",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CCF",
                table: "COMPRA",
                type: "VARCHAR",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_METAITEM",
                table: "METAITEM",
                column: "IdMetaItem");

            migrationBuilder.AddPrimaryKey(
                name: "PK_META",
                table: "META",
                column: "IdMeta");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MARCAITEM",
                table: "MARCAITEM",
                column: "IdMarcaItemView");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ITEMCOMPRA",
                table: "ITEMCOMPRA",
                column: "IdItemCompra");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ITEM",
                table: "ITEM",
                column: "IdItem");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DESCONTOITEM",
                table: "DESCONTOITEM",
                column: "IdDescontoItem");

            migrationBuilder.AddPrimaryKey(
                name: "PK_COMPRA",
                table: "COMPRA",
                column: "IdCompra");

            migrationBuilder.CreateTable(
                name: "ItemView",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descricao = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemView", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarcaItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    CodigoItem = table.Column<int>(type: "integer", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcaItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarcaItem_ITEM_CodigoItem",
                        column: x => x.CodigoItem,
                        principalTable: "ITEM",
                        principalColumn: "IdItem",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_METAITEM_CodigoMeta",
                table: "METAITEM",
                column: "CodigoMeta");

            migrationBuilder.CreateIndex(
                name: "IX_META_CodigoConsumidor",
                table: "META",
                column: "CodigoConsumidor");

            migrationBuilder.CreateIndex(
                name: "IX_MARCAITEM_CodigoItem",
                table: "MARCAITEM",
                column: "CodigoItem");

            migrationBuilder.CreateIndex(
                name: "IX_MARCAITEM_ItemViewId",
                table: "MARCAITEM",
                column: "ItemViewId");

            migrationBuilder.CreateIndex(
                name: "IX_ITEMCOMPRA_CodigoCompra",
                table: "ITEMCOMPRA",
                column: "CodigoCompra");

            migrationBuilder.CreateIndex(
                name: "IX_COMPRA_CodigoCondPagto",
                table: "COMPRA",
                column: "CodigoCondPagto");

            migrationBuilder.CreateIndex(
                name: "IX_COMPRA_CodigoEmpresa",
                table: "COMPRA",
                column: "CodigoEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_COMPRA_CodigoFormaPagto",
                table: "COMPRA",
                column: "CodigoFormaPagto");

            migrationBuilder.CreateIndex(
                name: "IX_MarcaItem_CodigoItem",
                table: "MarcaItem",
                column: "CodigoItem");

            migrationBuilder.AddForeignKey(
                name: "FK_COMPRA_CONDPAGTO_CodigoCondPagto",
                table: "COMPRA",
                column: "CodigoCondPagto",
                principalTable: "CONDPAGTO",
                principalColumn: "IdCondPagto");

            migrationBuilder.AddForeignKey(
                name: "FK_COMPRA_EMPRESA_CodigoEmpresa",
                table: "COMPRA",
                column: "CodigoEmpresa",
                principalTable: "EMPRESA",
                principalColumn: "IdEmpresa");

            migrationBuilder.AddForeignKey(
                name: "FK_COMPRA_FORMAPAGTO_CodigoFormaPagto",
                table: "COMPRA",
                column: "CodigoFormaPagto",
                principalTable: "FORMAPAGTO",
                principalColumn: "IdFormaPagto");

            migrationBuilder.AddForeignKey(
                name: "FK_DESCONTOITEM_ITEMCOMPRA_CodigoItemCompra",
                table: "DESCONTOITEM",
                column: "CodigoItemCompra",
                principalTable: "ITEMCOMPRA",
                principalColumn: "IdItemCompra",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ITEMCOMPRA_COMPRA_CodigoCompra",
                table: "ITEMCOMPRA",
                column: "CodigoCompra",
                principalTable: "COMPRA",
                principalColumn: "IdCompra",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MARCAITEM_ItemView_CodigoItem",
                table: "MARCAITEM",
                column: "CodigoItem",
                principalTable: "ItemView",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MARCAITEM_ItemView_ItemViewId",
                table: "MARCAITEM",
                column: "ItemViewId",
                principalTable: "ItemView",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_META_Consumidor_CodigoConsumidor",
                table: "META",
                column: "CodigoConsumidor",
                principalTable: "Consumidor",
                principalColumn: "IdConsumidor",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_METAITEM_META_CodigoMeta",
                table: "METAITEM",
                column: "CodigoMeta",
                principalTable: "META",
                principalColumn: "IdMeta",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_COMPRA_CONDPAGTO_CodigoCondPagto",
                table: "COMPRA");

            migrationBuilder.DropForeignKey(
                name: "FK_COMPRA_EMPRESA_CodigoEmpresa",
                table: "COMPRA");

            migrationBuilder.DropForeignKey(
                name: "FK_COMPRA_FORMAPAGTO_CodigoFormaPagto",
                table: "COMPRA");

            migrationBuilder.DropForeignKey(
                name: "FK_DESCONTOITEM_ITEMCOMPRA_CodigoItemCompra",
                table: "DESCONTOITEM");

            migrationBuilder.DropForeignKey(
                name: "FK_ITEMCOMPRA_COMPRA_CodigoCompra",
                table: "ITEMCOMPRA");

            migrationBuilder.DropForeignKey(
                name: "FK_MARCAITEM_ItemView_CodigoItem",
                table: "MARCAITEM");

            migrationBuilder.DropForeignKey(
                name: "FK_MARCAITEM_ItemView_ItemViewId",
                table: "MARCAITEM");

            migrationBuilder.DropForeignKey(
                name: "FK_META_Consumidor_CodigoConsumidor",
                table: "META");

            migrationBuilder.DropForeignKey(
                name: "FK_METAITEM_META_CodigoMeta",
                table: "METAITEM");

            migrationBuilder.DropTable(
                name: "ItemView");

            migrationBuilder.DropTable(
                name: "MarcaItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_METAITEM",
                table: "METAITEM");

            migrationBuilder.DropIndex(
                name: "IX_METAITEM_CodigoMeta",
                table: "METAITEM");

            migrationBuilder.DropPrimaryKey(
                name: "PK_META",
                table: "META");

            migrationBuilder.DropIndex(
                name: "IX_META_CodigoConsumidor",
                table: "META");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MARCAITEM",
                table: "MARCAITEM");

            migrationBuilder.DropIndex(
                name: "IX_MARCAITEM_CodigoItem",
                table: "MARCAITEM");

            migrationBuilder.DropIndex(
                name: "IX_MARCAITEM_ItemViewId",
                table: "MARCAITEM");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ITEMCOMPRA",
                table: "ITEMCOMPRA");

            migrationBuilder.DropIndex(
                name: "IX_ITEMCOMPRA_CodigoCompra",
                table: "ITEMCOMPRA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ITEM",
                table: "ITEM");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DESCONTOITEM",
                table: "DESCONTOITEM");

            migrationBuilder.DropPrimaryKey(
                name: "PK_COMPRA",
                table: "COMPRA");

            migrationBuilder.DropIndex(
                name: "IX_COMPRA_CodigoCondPagto",
                table: "COMPRA");

            migrationBuilder.DropIndex(
                name: "IX_COMPRA_CodigoEmpresa",
                table: "COMPRA");

            migrationBuilder.DropIndex(
                name: "IX_COMPRA_CodigoFormaPagto",
                table: "COMPRA");

            migrationBuilder.DropColumn(
                name: "ItemViewId",
                table: "MARCAITEM");

            migrationBuilder.RenameTable(
                name: "METAITEM",
                newName: "MetaItem");

            migrationBuilder.RenameTable(
                name: "META",
                newName: "Meta");

            migrationBuilder.RenameTable(
                name: "MARCAITEM",
                newName: "MarcaItem");

            migrationBuilder.RenameTable(
                name: "ITEMCOMPRA",
                newName: "ItemCompra");

            migrationBuilder.RenameTable(
                name: "ITEM",
                newName: "Item");

            migrationBuilder.RenameTable(
                name: "DESCONTOITEM",
                newName: "DescontoItem");

            migrationBuilder.RenameTable(
                name: "COMPRA",
                newName: "Compra");

            migrationBuilder.RenameColumn(
                name: "IdMetaItem",
                table: "MetaItem",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdMeta",
                table: "Meta",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdMarcaItemView",
                table: "MarcaItem",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdItemCompra",
                table: "ItemCompra",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdItem",
                table: "Item",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdDescontoItem",
                table: "DescontoItem",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_DESCONTOITEM_CodigoItemCompra",
                table: "DescontoItem",
                newName: "IX_DescontoItem_CodigoItemCompra");

            migrationBuilder.RenameColumn(
                name: "IdCompra",
                table: "Compra",
                newName: "Id");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorReservaCompra",
                table: "MetaItem",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorGuardarMes",
                table: "MetaItem",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorCompra",
                table: "MetaItem",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "LinkCompra",
                table: "MetaItem",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 900,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DiferencaCompraReserva",
                table: "MetaItem",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "MetaItem",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataExpectativaAquisicao",
                table: "MetaItem",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "MetaItem",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoMeta",
                table: "MetaItem",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AddColumn<int>(
                name: "MetaId",
                table: "MetaItem",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotalGuardado",
                table: "Meta",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotalCompra",
                table: "Meta",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Meta",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataIniVigencia",
                table: "Meta",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataFimVigencia",
                table: "Meta",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "Meta",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP");

            migrationBuilder.AddColumn<int>(
                name: "ConsumidorId",
                table: "Meta",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "MarcaItem",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "MarcaItem",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoItem",
                table: "MarcaItem",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "MarcaItem",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorUnitario",
                table: "ItemCompra",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotalItem",
                table: "ItemCompra",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "SequencialItem",
                table: "ItemCompra",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AlterColumn<decimal>(
                name: "Quantidade",
                table: "ItemCompra",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "ItemCompra",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "ItemCompra",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoDesconto",
                table: "ItemCompra",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CodigoCompra",
                table: "ItemCompra",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AddColumn<int>(
                name: "CompraId",
                table: "ItemCompra",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Item",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorDesconto",
                table: "DescontoItem",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoItemCompra",
                table: "DescontoItem",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTributos",
                table: "Compra",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotalNF",
                table: "Compra",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotalItens",
                table: "Compra",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotalDescontos",
                table: "Compra",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotal",
                table: "Compra",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(10,2)");

            migrationBuilder.AlterColumn<int>(
                name: "NumeroNF",
                table: "Compra",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Compra",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCompra",
                table: "Compra",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoFormaPagto",
                table: "Compra",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CodigoEmpresa",
                table: "Compra",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CodigoCondPagto",
                table: "Compra",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "COO",
                table: "Compra",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CCF",
                table: "Compra",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CondPagtoId",
                table: "Compra",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "Compra",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FormaPagtoId",
                table: "Compra",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MetaItem",
                table: "MetaItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Meta",
                table: "Meta",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MarcaItem",
                table: "MarcaItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemCompra",
                table: "ItemCompra",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DescontoItem",
                table: "DescontoItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Compra",
                table: "Compra",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_MetaItem_MetaId",
                table: "MetaItem",
                column: "MetaId");

            migrationBuilder.CreateIndex(
                name: "IX_Meta_ConsumidorId",
                table: "Meta",
                column: "ConsumidorId");

            migrationBuilder.CreateIndex(
                name: "IX_MarcaItem_ItemId",
                table: "MarcaItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCompra_CompraId",
                table: "ItemCompra",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_CondPagtoId",
                table: "Compra",
                column: "CondPagtoId");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_EmpresaId",
                table: "Compra",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_FormaPagtoId",
                table: "Compra",
                column: "FormaPagtoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_CONDPAGTO_CondPagtoId",
                table: "Compra",
                column: "CondPagtoId",
                principalTable: "CONDPAGTO",
                principalColumn: "IdCondPagto");

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_EMPRESA_EmpresaId",
                table: "Compra",
                column: "EmpresaId",
                principalTable: "EMPRESA",
                principalColumn: "IdEmpresa");

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_FORMAPAGTO_FormaPagtoId",
                table: "Compra",
                column: "FormaPagtoId",
                principalTable: "FORMAPAGTO",
                principalColumn: "IdFormaPagto");

            migrationBuilder.AddForeignKey(
                name: "FK_DescontoItem_ItemCompra_CodigoItemCompra",
                table: "DescontoItem",
                column: "CodigoItemCompra",
                principalTable: "ItemCompra",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemCompra_Compra_CompraId",
                table: "ItemCompra",
                column: "CompraId",
                principalTable: "Compra",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MarcaItem_Item_ItemId",
                table: "MarcaItem",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Meta_Consumidor_ConsumidorId",
                table: "Meta",
                column: "ConsumidorId",
                principalTable: "Consumidor",
                principalColumn: "IdConsumidor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MetaItem_Meta_MetaId",
                table: "MetaItem",
                column: "MetaId",
                principalTable: "Meta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
