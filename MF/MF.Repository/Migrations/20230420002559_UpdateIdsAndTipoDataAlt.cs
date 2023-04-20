using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MF.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateIdsAndTipoDataAlt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_DESCONTOITEM_ITEMCOMPRA_ID_ITEM_COMPRA",
                table: "DESCONTOITEM");

            migrationBuilder.DropForeignKey(
                name: "FK_DESPESA_CONDPAGTO_CodigoCondPagto",
                table: "DESPESA");

            migrationBuilder.DropForeignKey(
                name: "FK_DESPESA_CONSUMIDOR_CodigoConsumidor",
                table: "DESPESA");

            migrationBuilder.DropForeignKey(
                name: "FK_DESPESA_EMPRESA_CodigoEmpresa",
                table: "DESPESA");

            migrationBuilder.DropForeignKey(
                name: "FK_DESPESA_FORMAPAGTO_CodigoFormaPagto",
                table: "DESPESA");

            migrationBuilder.DropForeignKey(
                name: "FK_ITEMCOMPRA_COMPRA_ID_COMPRA",
                table: "ITEMCOMPRA");

            migrationBuilder.DropForeignKey(
                name: "FK_METAITEM_META_CodigoMeta",
                table: "METAITEM");

            migrationBuilder.DropForeignKey(
                name: "FK_RENDA_CONSUMIDOR_CodigoConsumidor",
                table: "RENDA");

            migrationBuilder.DropForeignKey(
                name: "FK_RENDA_EMPRESA_CodigoEmpresa",
                table: "RENDA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ITEMCOMPRA",
                table: "ITEMCOMPRA");

            migrationBuilder.RenameColumn(
                name: "DATA_ALTERACAO",
                table: "RENDA",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "CodigoEmpresa",
                table: "RENDA",
                newName: "CODIGO_EMPRESA");

            migrationBuilder.RenameColumn(
                name: "CodigoConsumidor",
                table: "RENDA",
                newName: "CODIGO_CONSUMIDOR");

            migrationBuilder.RenameIndex(
                name: "IX_RENDA_CodigoEmpresa",
                table: "RENDA",
                newName: "IX_RENDA_CODIGO_EMPRESA");

            migrationBuilder.RenameIndex(
                name: "IX_RENDA_CodigoConsumidor",
                table: "RENDA",
                newName: "IX_RENDA_CODIGO_CONSUMIDOR");

            migrationBuilder.RenameColumn(
                name: "DATA_ALTERACAO",
                table: "METAITEM",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "CodigoMeta",
                table: "METAITEM",
                newName: "CODIGO_META");

            migrationBuilder.RenameIndex(
                name: "IX_METAITEM_CodigoMeta",
                table: "METAITEM",
                newName: "IX_METAITEM_CODIGO_META");

            migrationBuilder.RenameColumn(
                name: "DATA_ALTERACAO",
                table: "META",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "DATA_ALTERACAO",
                table: "MARCAITEM",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "DATA_ALTERACAO",
                table: "ITEMCOMPRA",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "CodigoDesconto",
                table: "ITEMCOMPRA",
                newName: "CODIGO_DESCONTO");

            migrationBuilder.RenameColumn(
                name: "ID_COMPRA",
                table: "ITEMCOMPRA",
                newName: "CODIGO_COMPRA");

            migrationBuilder.RenameColumn(
                name: "DATA_ALTERACAO",
                table: "DESPESA",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "CodigoFormaPagto",
                table: "DESPESA",
                newName: "CODIGO_FORMA_PAGTO");

            migrationBuilder.RenameColumn(
                name: "CodigoEmpresa",
                table: "DESPESA",
                newName: "CODIGO_EMPRESA");

            migrationBuilder.RenameColumn(
                name: "CodigoConsumidor",
                table: "DESPESA",
                newName: "CODIGO_CONSUMIDOR");

            migrationBuilder.RenameColumn(
                name: "CodigoCondPagto",
                table: "DESPESA",
                newName: "CODIGO_COND_PAGTO");

            migrationBuilder.RenameIndex(
                name: "IX_DESPESA_CodigoFormaPagto",
                table: "DESPESA",
                newName: "IX_DESPESA_CODIGO_FORMA_PAGTO");

            migrationBuilder.RenameIndex(
                name: "IX_DESPESA_CodigoEmpresa",
                table: "DESPESA",
                newName: "IX_DESPESA_CODIGO_EMPRESA");

            migrationBuilder.RenameIndex(
                name: "IX_DESPESA_CodigoConsumidor",
                table: "DESPESA",
                newName: "IX_DESPESA_CODIGO_CONSUMIDOR");

            migrationBuilder.RenameIndex(
                name: "IX_DESPESA_CodigoCondPagto",
                table: "DESPESA",
                newName: "IX_DESPESA_CODIGO_COND_PAGTO");

            migrationBuilder.RenameColumn(
                name: "DATA_ALTERACAO",
                table: "CONSUMIDOR",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "CodigoFormaPagto",
                table: "COMPRA",
                newName: "CODIGO_FORMA_PAGTO");

            migrationBuilder.RenameColumn(
                name: "CodigoEmpresa",
                table: "COMPRA",
                newName: "CODIGO_EMPRESA");

            migrationBuilder.RenameColumn(
                name: "CodigoCondPagto",
                table: "COMPRA",
                newName: "CODIGO_COND_PAGTO");

            migrationBuilder.RenameIndex(
                name: "IX_COMPRA_CodigoFormaPagto",
                table: "COMPRA",
                newName: "IX_COMPRA_CODIGO_FORMA_PAGTO");

            migrationBuilder.RenameIndex(
                name: "IX_COMPRA_CodigoEmpresa",
                table: "COMPRA",
                newName: "IX_COMPRA_CODIGO_EMPRESA");

            migrationBuilder.RenameIndex(
                name: "IX_COMPRA_CodigoCondPagto",
                table: "COMPRA",
                newName: "IX_COMPRA_CODIGO_COND_PAGTO");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "RENDA",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<int>(
                name: "CODIGO_EMPRESA",
                table: "RENDA",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CODIGO_CONSUMIDOR",
                table: "RENDA",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "METAITEM",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<int>(
                name: "CODIGO_META",
                table: "METAITEM",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "META",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "MARCAITEM",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AddColumn<int>(
                name: "CODIGO_ITEM",
                table: "MARCAITEM",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "MARCAITEM",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_ITEM",
                table: "ITEMCOMPRA",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ITEMCOMPRA",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "ITEMCOMPRA",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<int>(
                name: "CODIGO_DESCONTO",
                table: "ITEMCOMPRA",
                type: "INT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CODIGO_COMPRA",
                table: "ITEMCOMPRA",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "DESPESA",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<int>(
                name: "CODIGO_FORMA_PAGTO",
                table: "DESPESA",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CODIGO_EMPRESA",
                table: "DESPESA",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CODIGO_CONSUMIDOR",
                table: "DESPESA",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CODIGO_COND_PAGTO",
                table: "DESPESA",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "CONSUMIDOR",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<int>(
                name: "CODIGO_FORMA_PAGTO",
                table: "COMPRA",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CODIGO_EMPRESA",
                table: "COMPRA",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CODIGO_COND_PAGTO",
                table: "COMPRA",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ITEMCOMPRA",
                table: "ITEMCOMPRA",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_MARCAITEM_CODIGO_ITEM",
                table: "MARCAITEM",
                column: "CODIGO_ITEM");

            migrationBuilder.CreateIndex(
                name: "IX_MARCAITEM_ItemId",
                table: "MARCAITEM",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ITEMCOMPRA_CODIGO_COMPRA",
                table: "ITEMCOMPRA",
                column: "CODIGO_COMPRA");

            migrationBuilder.AddForeignKey(
                name: "FK_COMPRA_CONDPAGTO_CODIGO_COND_PAGTO",
                table: "COMPRA",
                column: "CODIGO_COND_PAGTO",
                principalTable: "CONDPAGTO",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_COMPRA_EMPRESA_CODIGO_EMPRESA",
                table: "COMPRA",
                column: "CODIGO_EMPRESA",
                principalTable: "EMPRESA",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_COMPRA_FORMAPAGTO_CODIGO_FORMA_PAGTO",
                table: "COMPRA",
                column: "CODIGO_FORMA_PAGTO",
                principalTable: "FORMAPAGTO",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DESCONTOITEM_ITEMCOMPRA_ID_ITEM_COMPRA",
                table: "DESCONTOITEM",
                column: "ID_ITEM_COMPRA",
                principalTable: "ITEMCOMPRA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DESPESA_CONDPAGTO_CODIGO_COND_PAGTO",
                table: "DESPESA",
                column: "CODIGO_COND_PAGTO",
                principalTable: "CONDPAGTO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DESPESA_CONSUMIDOR_CODIGO_CONSUMIDOR",
                table: "DESPESA",
                column: "CODIGO_CONSUMIDOR",
                principalTable: "CONSUMIDOR",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DESPESA_EMPRESA_CODIGO_EMPRESA",
                table: "DESPESA",
                column: "CODIGO_EMPRESA",
                principalTable: "EMPRESA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DESPESA_FORMAPAGTO_CODIGO_FORMA_PAGTO",
                table: "DESPESA",
                column: "CODIGO_FORMA_PAGTO",
                principalTable: "FORMAPAGTO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ITEMCOMPRA_COMPRA_CODIGO_COMPRA",
                table: "ITEMCOMPRA",
                column: "CODIGO_COMPRA",
                principalTable: "COMPRA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MARCAITEM_ITEM_CODIGO_ITEM",
                table: "MARCAITEM",
                column: "CODIGO_ITEM",
                principalTable: "ITEM",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MARCAITEM_ITEM_ItemId",
                table: "MARCAITEM",
                column: "ItemId",
                principalTable: "ITEM",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_METAITEM_META_CODIGO_META",
                table: "METAITEM",
                column: "CODIGO_META",
                principalTable: "META",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RENDA_CONSUMIDOR_CODIGO_CONSUMIDOR",
                table: "RENDA",
                column: "CODIGO_CONSUMIDOR",
                principalTable: "CONSUMIDOR",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RENDA_EMPRESA_CODIGO_EMPRESA",
                table: "RENDA",
                column: "CODIGO_EMPRESA",
                principalTable: "EMPRESA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_COMPRA_CONDPAGTO_CODIGO_COND_PAGTO",
                table: "COMPRA");

            migrationBuilder.DropForeignKey(
                name: "FK_COMPRA_EMPRESA_CODIGO_EMPRESA",
                table: "COMPRA");

            migrationBuilder.DropForeignKey(
                name: "FK_COMPRA_FORMAPAGTO_CODIGO_FORMA_PAGTO",
                table: "COMPRA");

            migrationBuilder.DropForeignKey(
                name: "FK_DESCONTOITEM_ITEMCOMPRA_ID_ITEM_COMPRA",
                table: "DESCONTOITEM");

            migrationBuilder.DropForeignKey(
                name: "FK_DESPESA_CONDPAGTO_CODIGO_COND_PAGTO",
                table: "DESPESA");

            migrationBuilder.DropForeignKey(
                name: "FK_DESPESA_CONSUMIDOR_CODIGO_CONSUMIDOR",
                table: "DESPESA");

            migrationBuilder.DropForeignKey(
                name: "FK_DESPESA_EMPRESA_CODIGO_EMPRESA",
                table: "DESPESA");

            migrationBuilder.DropForeignKey(
                name: "FK_DESPESA_FORMAPAGTO_CODIGO_FORMA_PAGTO",
                table: "DESPESA");

            migrationBuilder.DropForeignKey(
                name: "FK_ITEMCOMPRA_COMPRA_CODIGO_COMPRA",
                table: "ITEMCOMPRA");

            migrationBuilder.DropForeignKey(
                name: "FK_MARCAITEM_ITEM_CODIGO_ITEM",
                table: "MARCAITEM");

            migrationBuilder.DropForeignKey(
                name: "FK_MARCAITEM_ITEM_ItemId",
                table: "MARCAITEM");

            migrationBuilder.DropForeignKey(
                name: "FK_METAITEM_META_CODIGO_META",
                table: "METAITEM");

            migrationBuilder.DropForeignKey(
                name: "FK_RENDA_CONSUMIDOR_CODIGO_CONSUMIDOR",
                table: "RENDA");

            migrationBuilder.DropForeignKey(
                name: "FK_RENDA_EMPRESA_CODIGO_EMPRESA",
                table: "RENDA");

            migrationBuilder.DropIndex(
                name: "IX_MARCAITEM_CODIGO_ITEM",
                table: "MARCAITEM");

            migrationBuilder.DropIndex(
                name: "IX_MARCAITEM_ItemId",
                table: "MARCAITEM");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ITEMCOMPRA",
                table: "ITEMCOMPRA");

            migrationBuilder.DropIndex(
                name: "IX_ITEMCOMPRA_CODIGO_COMPRA",
                table: "ITEMCOMPRA");

            migrationBuilder.DropColumn(
                name: "CODIGO_ITEM",
                table: "MARCAITEM");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "MARCAITEM");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "RENDA",
                newName: "DATA_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CODIGO_EMPRESA",
                table: "RENDA",
                newName: "CodigoEmpresa");

            migrationBuilder.RenameColumn(
                name: "CODIGO_CONSUMIDOR",
                table: "RENDA",
                newName: "CodigoConsumidor");

            migrationBuilder.RenameIndex(
                name: "IX_RENDA_CODIGO_EMPRESA",
                table: "RENDA",
                newName: "IX_RENDA_CodigoEmpresa");

            migrationBuilder.RenameIndex(
                name: "IX_RENDA_CODIGO_CONSUMIDOR",
                table: "RENDA",
                newName: "IX_RENDA_CodigoConsumidor");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "METAITEM",
                newName: "DATA_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CODIGO_META",
                table: "METAITEM",
                newName: "CodigoMeta");

            migrationBuilder.RenameIndex(
                name: "IX_METAITEM_CODIGO_META",
                table: "METAITEM",
                newName: "IX_METAITEM_CodigoMeta");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "META",
                newName: "DATA_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "MARCAITEM",
                newName: "DATA_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "ITEMCOMPRA",
                newName: "DATA_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CODIGO_DESCONTO",
                table: "ITEMCOMPRA",
                newName: "CodigoDesconto");

            migrationBuilder.RenameColumn(
                name: "CODIGO_COMPRA",
                table: "ITEMCOMPRA",
                newName: "ID_COMPRA");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "DESPESA",
                newName: "DATA_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CODIGO_FORMA_PAGTO",
                table: "DESPESA",
                newName: "CodigoFormaPagto");

            migrationBuilder.RenameColumn(
                name: "CODIGO_EMPRESA",
                table: "DESPESA",
                newName: "CodigoEmpresa");

            migrationBuilder.RenameColumn(
                name: "CODIGO_CONSUMIDOR",
                table: "DESPESA",
                newName: "CodigoConsumidor");

            migrationBuilder.RenameColumn(
                name: "CODIGO_COND_PAGTO",
                table: "DESPESA",
                newName: "CodigoCondPagto");

            migrationBuilder.RenameIndex(
                name: "IX_DESPESA_CODIGO_FORMA_PAGTO",
                table: "DESPESA",
                newName: "IX_DESPESA_CodigoFormaPagto");

            migrationBuilder.RenameIndex(
                name: "IX_DESPESA_CODIGO_EMPRESA",
                table: "DESPESA",
                newName: "IX_DESPESA_CodigoEmpresa");

            migrationBuilder.RenameIndex(
                name: "IX_DESPESA_CODIGO_CONSUMIDOR",
                table: "DESPESA",
                newName: "IX_DESPESA_CodigoConsumidor");

            migrationBuilder.RenameIndex(
                name: "IX_DESPESA_CODIGO_COND_PAGTO",
                table: "DESPESA",
                newName: "IX_DESPESA_CodigoCondPagto");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "CONSUMIDOR",
                newName: "DATA_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CODIGO_FORMA_PAGTO",
                table: "COMPRA",
                newName: "CodigoFormaPagto");

            migrationBuilder.RenameColumn(
                name: "CODIGO_EMPRESA",
                table: "COMPRA",
                newName: "CodigoEmpresa");

            migrationBuilder.RenameColumn(
                name: "CODIGO_COND_PAGTO",
                table: "COMPRA",
                newName: "CodigoCondPagto");

            migrationBuilder.RenameIndex(
                name: "IX_COMPRA_CODIGO_FORMA_PAGTO",
                table: "COMPRA",
                newName: "IX_COMPRA_CodigoFormaPagto");

            migrationBuilder.RenameIndex(
                name: "IX_COMPRA_CODIGO_EMPRESA",
                table: "COMPRA",
                newName: "IX_COMPRA_CodigoEmpresa");

            migrationBuilder.RenameIndex(
                name: "IX_COMPRA_CODIGO_COND_PAGTO",
                table: "COMPRA",
                newName: "IX_COMPRA_CodigoCondPagto");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_ALTERACAO",
                table: "RENDA",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoEmpresa",
                table: "RENDA",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CodigoConsumidor",
                table: "RENDA",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_ALTERACAO",
                table: "METAITEM",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoMeta",
                table: "METAITEM",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_ALTERACAO",
                table: "META",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_ALTERACAO",
                table: "MARCAITEM",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_ITEM",
                table: "ITEMCOMPRA",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ITEMCOMPRA",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_ALTERACAO",
                table: "ITEMCOMPRA",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoDesconto",
                table: "ITEMCOMPRA",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID_COMPRA",
                table: "ITEMCOMPRA",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_ALTERACAO",
                table: "DESPESA",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoFormaPagto",
                table: "DESPESA",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoEmpresa",
                table: "DESPESA",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoConsumidor",
                table: "DESPESA",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoCondPagto",
                table: "DESPESA",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_ALTERACAO",
                table: "CONSUMIDOR",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoFormaPagto",
                table: "COMPRA",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CodigoEmpresa",
                table: "COMPRA",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CodigoCondPagto",
                table: "COMPRA",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ITEMCOMPRA",
                table: "ITEMCOMPRA",
                column: "ID_COMPRA");

            migrationBuilder.AddForeignKey(
                name: "FK_COMPRA_CONDPAGTO_CodigoCondPagto",
                table: "COMPRA",
                column: "CodigoCondPagto",
                principalTable: "CONDPAGTO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_COMPRA_EMPRESA_CodigoEmpresa",
                table: "COMPRA",
                column: "CodigoEmpresa",
                principalTable: "EMPRESA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_COMPRA_FORMAPAGTO_CodigoFormaPagto",
                table: "COMPRA",
                column: "CodigoFormaPagto",
                principalTable: "FORMAPAGTO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DESCONTOITEM_ITEMCOMPRA_ID_ITEM_COMPRA",
                table: "DESCONTOITEM",
                column: "ID_ITEM_COMPRA",
                principalTable: "ITEMCOMPRA",
                principalColumn: "ID_COMPRA",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DESPESA_CONDPAGTO_CodigoCondPagto",
                table: "DESPESA",
                column: "CodigoCondPagto",
                principalTable: "CONDPAGTO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DESPESA_CONSUMIDOR_CodigoConsumidor",
                table: "DESPESA",
                column: "CodigoConsumidor",
                principalTable: "CONSUMIDOR",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DESPESA_EMPRESA_CodigoEmpresa",
                table: "DESPESA",
                column: "CodigoEmpresa",
                principalTable: "EMPRESA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DESPESA_FORMAPAGTO_CodigoFormaPagto",
                table: "DESPESA",
                column: "CodigoFormaPagto",
                principalTable: "FORMAPAGTO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ITEMCOMPRA_COMPRA_ID_COMPRA",
                table: "ITEMCOMPRA",
                column: "ID_COMPRA",
                principalTable: "COMPRA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_METAITEM_META_CodigoMeta",
                table: "METAITEM",
                column: "CodigoMeta",
                principalTable: "META",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RENDA_CONSUMIDOR_CodigoConsumidor",
                table: "RENDA",
                column: "CodigoConsumidor",
                principalTable: "CONSUMIDOR",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RENDA_EMPRESA_CodigoEmpresa",
                table: "RENDA",
                column: "CodigoEmpresa",
                principalTable: "EMPRESA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
