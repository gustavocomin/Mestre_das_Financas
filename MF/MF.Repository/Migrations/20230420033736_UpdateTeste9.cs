using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MF.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTeste9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_CONDPAGTOPARC_CONDPAGTO_ID_COND_PAGTO",
                table: "CONDPAGTOPARC");

            migrationBuilder.DropForeignKey(
                name: "FK_DESCONTOITEM_ITEMCOMPRA_ID_ITEM_COMPRA",
                table: "DESCONTOITEM");

            migrationBuilder.DropForeignKey(
                name: "FK_Despesa_CONDPAGTO_CondPagtoId",
                table: "Despesa");

            migrationBuilder.DropForeignKey(
                name: "FK_Despesa_CONSUMIDOR_CodigoConsumidor",
                table: "Despesa");

            migrationBuilder.DropForeignKey(
                name: "FK_Despesa_EMPRESA_EmpresaId",
                table: "Despesa");

            migrationBuilder.DropForeignKey(
                name: "FK_Despesa_FORMAPAGTO_FormaPagtoId",
                table: "Despesa");

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
                name: "FK_META_CONSUMIDOR_CodigoConsumidor",
                table: "META");

            migrationBuilder.DropForeignKey(
                name: "FK_METAITEM_META_CODIGO_META",
                table: "METAITEM");

            migrationBuilder.DropForeignKey(
                name: "FK_RENDA_CONSUMIDOR_CODIGO_CONSUMIDOR",
                table: "RENDA");

            migrationBuilder.DropForeignKey(
                name: "FK_RENDA_CONSUMIDOR_ConsumidorId",
                table: "RENDA");

            migrationBuilder.DropForeignKey(
                name: "FK_RENDA_EMPRESA_CODIGO_EMPRESA",
                table: "RENDA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RENDA",
                table: "RENDA");

            migrationBuilder.DropIndex(
                name: "IX_RENDA_CODIGO_CONSUMIDOR",
                table: "RENDA");

            migrationBuilder.DropIndex(
                name: "IX_RENDA_CODIGO_EMPRESA",
                table: "RENDA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_METAITEM",
                table: "METAITEM");

            migrationBuilder.DropIndex(
                name: "IX_METAITEM_CODIGO_META",
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
                name: "IX_MARCAITEM_CODIGO_ITEM",
                table: "MARCAITEM");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ITEMCOMPRA",
                table: "ITEMCOMPRA");

            migrationBuilder.DropIndex(
                name: "IX_ITEMCOMPRA_CODIGO_COMPRA",
                table: "ITEMCOMPRA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ITEM",
                table: "ITEM");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FORMAPAGTO",
                table: "FORMAPAGTO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EMPRESA",
                table: "EMPRESA");

            migrationBuilder.DropIndex(
                name: "IX_Despesa_CodigoConsumidor",
                table: "Despesa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DESCONTOITEM",
                table: "DESCONTOITEM");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CONSUMIDOR",
                table: "CONSUMIDOR");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CONDPAGTO",
                table: "CONDPAGTO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_COMPRA",
                table: "COMPRA");

            migrationBuilder.DropIndex(
                name: "IX_COMPRA_CODIGO_COND_PAGTO",
                table: "COMPRA");

            migrationBuilder.DropIndex(
                name: "IX_COMPRA_CODIGO_EMPRESA",
                table: "COMPRA");

            migrationBuilder.DropIndex(
                name: "IX_COMPRA_CODIGO_FORMA_PAGTO",
                table: "COMPRA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CONDPAGTOPARC",
                table: "CONDPAGTOPARC");

            migrationBuilder.DropIndex(
                name: "IX_CONDPAGTOPARC_ID_COND_PAGTO",
                table: "CONDPAGTOPARC");

            migrationBuilder.RenameTable(
                name: "RENDA",
                newName: "Renda");

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
                name: "FORMAPAGTO",
                newName: "FormaPagto");

            migrationBuilder.RenameTable(
                name: "EMPRESA",
                newName: "Empresa");

            migrationBuilder.RenameTable(
                name: "DESCONTOITEM",
                newName: "DescontoItem");

            migrationBuilder.RenameTable(
                name: "CONSUMIDOR",
                newName: "Consumidor");

            migrationBuilder.RenameTable(
                name: "CONDPAGTO",
                newName: "CondPagto");

            migrationBuilder.RenameTable(
                name: "COMPRA",
                newName: "Compra");

            migrationBuilder.RenameTable(
                name: "CONDPAGTOPARC",
                newName: "CondPagtoParcs");

            migrationBuilder.RenameColumn(
                name: "VALOR",
                table: "Renda",
                newName: "Valor");

            migrationBuilder.RenameColumn(
                name: "SALARIO",
                table: "Renda",
                newName: "Salario");

            migrationBuilder.RenameColumn(
                name: "DESCRICAO",
                table: "Renda",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "Renda",
                newName: "DATA_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CODIGO_EMPRESA",
                table: "Renda",
                newName: "CodigoEmpresa");

            migrationBuilder.RenameColumn(
                name: "CODIGO_CONSUMIDOR",
                table: "Renda",
                newName: "CodigoConsumidor");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Renda",
                newName: "ID_RENDA");

            migrationBuilder.RenameIndex(
                name: "IX_RENDA_ConsumidorId",
                table: "Renda",
                newName: "IX_Renda_ConsumidorId");

            migrationBuilder.RenameColumn(
                name: "STATUS",
                table: "MetaItem",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "DESCRICAO",
                table: "MetaItem",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "VALOR_RESERVA_COMPRA",
                table: "MetaItem",
                newName: "ValorReservaCompra");

            migrationBuilder.RenameColumn(
                name: "VALOR_GUARDAR_MES",
                table: "MetaItem",
                newName: "ValorGuardarMes");

            migrationBuilder.RenameColumn(
                name: "VALOR_COMPRA",
                table: "MetaItem",
                newName: "ValorCompra");

            migrationBuilder.RenameColumn(
                name: "LINK_COMPRA",
                table: "MetaItem",
                newName: "LinkCompra");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "MetaItem",
                newName: "DATA_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "DIFERENCA_COMPRA_RESERVA",
                table: "MetaItem",
                newName: "DiferencaCompraReserva");

            migrationBuilder.RenameColumn(
                name: "DATA_EXPECTATIVA_AQUISICAO",
                table: "MetaItem",
                newName: "DataExpectativaAquisicao");

            migrationBuilder.RenameColumn(
                name: "CODIGO_META",
                table: "MetaItem",
                newName: "CodigoMeta");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MetaItem",
                newName: "ID_METAITEM");

            migrationBuilder.RenameColumn(
                name: "STATUS",
                table: "Meta",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "DESCRICAO",
                table: "Meta",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "VALOR_TOTAL_GUARDADO",
                table: "Meta",
                newName: "ValorTotalGuardado");

            migrationBuilder.RenameColumn(
                name: "VALOR_TOTAL_COMPRA",
                table: "Meta",
                newName: "ValorTotalCompra");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "Meta",
                newName: "DATA_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "DATA_INI_VIGENCIA",
                table: "Meta",
                newName: "DataIniVigencia");

            migrationBuilder.RenameColumn(
                name: "DATA_FIM_VIGENCIA",
                table: "Meta",
                newName: "DataFimVigencia");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Meta",
                newName: "ID_META");

            migrationBuilder.RenameColumn(
                name: "DESCRICAO",
                table: "MarcaItem",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "MarcaItem",
                newName: "DATA_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CODIGO_ITEM",
                table: "MarcaItem",
                newName: "CodigoItem");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MarcaItem",
                newName: "ID_MARCAITEM");

            migrationBuilder.RenameIndex(
                name: "IX_MARCAITEM_ItemId",
                table: "MarcaItem",
                newName: "IX_MarcaItem_ItemId");

            migrationBuilder.RenameColumn(
                name: "DESCRICAO",
                table: "ItemCompra",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "VALOR_UNIT",
                table: "ItemCompra",
                newName: "ValorUnitario");

            migrationBuilder.RenameColumn(
                name: "VALOR_TOTAL_ITEM",
                table: "ItemCompra",
                newName: "ValorTotalItem");

            migrationBuilder.RenameColumn(
                name: "SEQ_ITEM",
                table: "ItemCompra",
                newName: "SequencialItem");

            migrationBuilder.RenameColumn(
                name: "QUANT",
                table: "ItemCompra",
                newName: "Quantidade");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "ItemCompra",
                newName: "DATA_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CODIGO_DESCONTO",
                table: "ItemCompra",
                newName: "CodigoDesconto");

            migrationBuilder.RenameColumn(
                name: "CODIGO_COMPRA",
                table: "ItemCompra",
                newName: "CodigoCompra");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ItemCompra",
                newName: "ID_ITEMCOMPRA");

            migrationBuilder.RenameColumn(
                name: "DESCRICAO",
                table: "Item",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Item",
                newName: "ID_ITEM");

            migrationBuilder.RenameColumn(
                name: "DESCRICAO",
                table: "FormaPagto",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "FormaPagto",
                newName: "ID_FORMAPAGTO");

            migrationBuilder.RenameColumn(
                name: "ENDEREÇO",
                table: "Empresa",
                newName: "Endereço");

            migrationBuilder.RenameColumn(
                name: "COMPLEMENTO",
                table: "Empresa",
                newName: "Complemento");

            migrationBuilder.RenameColumn(
                name: "CIDADE",
                table: "Empresa",
                newName: "Cidade");

            migrationBuilder.RenameColumn(
                name: "BAIRRO",
                table: "Empresa",
                newName: "Bairro");

            migrationBuilder.RenameColumn(
                name: "NOME_EMPRESA",
                table: "Empresa",
                newName: "NomeEmpresa");

            migrationBuilder.RenameColumn(
                name: "CNPJ_EMPRESA",
                table: "Empresa",
                newName: "CnpjEmpresa");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Empresa",
                newName: "ID_EMPRESA");

            migrationBuilder.RenameColumn(
                name: "VALOR_DESCONTO",
                table: "DescontoItem",
                newName: "ValorDesconto");

            migrationBuilder.RenameColumn(
                name: "ID_ITEM_COMPRA",
                table: "DescontoItem",
                newName: "CodigoItemCompra");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DescontoItem",
                newName: "ID_DESCONTOITEM");

            migrationBuilder.RenameIndex(
                name: "IX_DESCONTOITEM_ID_ITEM_COMPRA",
                table: "DescontoItem",
                newName: "IX_DescontoItem_CodigoItemCompra");

            migrationBuilder.RenameColumn(
                name: "NOME",
                table: "Consumidor",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "EMAIL",
                table: "Consumidor",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "CELULAR",
                table: "Consumidor",
                newName: "Celular");

            migrationBuilder.RenameColumn(
                name: "RENDA_TOTAL",
                table: "Consumidor",
                newName: "RendaTotal");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "Consumidor",
                newName: "DATA_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "DATA_NASCIMENTO",
                table: "Consumidor",
                newName: "DataNascimento");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Consumidor",
                newName: "ID_CONSUMIDOR");

            migrationBuilder.RenameColumn(
                name: "DESCRICAO",
                table: "CondPagto",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "CREDITO",
                table: "CondPagto",
                newName: "Credito");

            migrationBuilder.RenameColumn(
                name: "QUANT_PARC",
                table: "CondPagto",
                newName: "QuantParc");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CondPagto",
                newName: "ID_CONDPAGTO");

            migrationBuilder.RenameColumn(
                name: "DESCRICAO",
                table: "Compra",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "VALOR_TRIBUTOS",
                table: "Compra",
                newName: "ValorTributos");

            migrationBuilder.RenameColumn(
                name: "VALOR_TOTAL_ITENS",
                table: "Compra",
                newName: "ValorTotalItens");

            migrationBuilder.RenameColumn(
                name: "VALOR_TOTAL_DESCONTOS",
                table: "Compra",
                newName: "ValorTotalDescontos");

            migrationBuilder.RenameColumn(
                name: "VALOR_TOTAL",
                table: "Compra",
                newName: "ValorTotal");

            migrationBuilder.RenameColumn(
                name: "DATA_COMPRA",
                table: "Compra",
                newName: "DataCompra");

            migrationBuilder.RenameColumn(
                name: "CODIGO_FORMA_PAGTO",
                table: "Compra",
                newName: "CodigoFormaPagto");

            migrationBuilder.RenameColumn(
                name: "CODIGO_EMPRESA",
                table: "Compra",
                newName: "CodigoEmpresa");

            migrationBuilder.RenameColumn(
                name: "CODIGO_COND_PAGTO",
                table: "Compra",
                newName: "CodigoCondPagto");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Compra",
                newName: "ID_COMPRA");

            migrationBuilder.RenameColumn(
                name: "VALOR_PARC",
                table: "CondPagtoParcs",
                newName: "ValorParc");

            migrationBuilder.RenameColumn(
                name: "SEQ_PARC",
                table: "CondPagtoParcs",
                newName: "SeqParc");

            migrationBuilder.RenameColumn(
                name: "ID_COND_PAGTO",
                table: "CondPagtoParcs",
                newName: "CodigoCondPagto");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CondPagtoParcs",
                newName: "ID_CONDPAGTOPARCS");

            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "Renda",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "ConsumidorId",
                table: "Renda",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_ALTERACAO",
                table: "Renda",
                type: "TIMESTAMP",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoEmpresa",
                table: "Renda",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CodigoConsumidor",
                table: "Renda",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "Renda",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "MetaItem",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 200);

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

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_ALTERACAO",
                table: "MetaItem",
                type: "TIMESTAMP",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<decimal>(
                name: "DiferencaCompraReserva",
                table: "MetaItem",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(18,2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataExpectativaAquisicao",
                table: "MetaItem",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

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

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Meta",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 100);

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

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_ALTERACAO",
                table: "Meta",
                type: "TIMESTAMP",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

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

            migrationBuilder.AddColumn<int>(
                name: "ConsumidorId",
                table: "Meta",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ItemId",
                table: "MarcaItem",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "MarcaItem",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_ALTERACAO",
                table: "MarcaItem",
                type: "TIMESTAMP",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoItem",
                table: "MarcaItem",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "ItemCompra",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200);

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

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_ALTERACAO",
                table: "ItemCompra",
                type: "TIMESTAMP",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

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

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "FormaPagto",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Endereço",
                table: "Empresa",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "Empresa",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Empresa",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Empresa",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomeEmpresa",
                table: "Empresa",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "CnpjEmpresa",
                table: "Empresa",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(14)",
                oldMaxLength: 14,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConsumidorId",
                table: "Despesa",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Consumidor",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Consumidor",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Celular",
                table: "Consumidor",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RendaTotal",
                table: "Consumidor",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(18,2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_ALTERACAO",
                table: "Consumidor",
                type: "TIMESTAMP",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimento",
                table: "Consumidor",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "CondPagto",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<int>(
                name: "QuantParc",
                table: "CondPagto",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Compra",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR",
                oldMaxLength: 50);

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

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTributos",
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

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorParc",
                table: "CondPagtoParcs",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "SeqParc",
                table: "CondPagtoParcs",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoCondPagto",
                table: "CondPagtoParcs",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CondPagtoId",
                table: "CondPagtoParcs",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Renda",
                table: "Renda",
                column: "ID_RENDA");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MetaItem",
                table: "MetaItem",
                column: "ID_METAITEM");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Meta",
                table: "Meta",
                column: "ID_META");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MarcaItem",
                table: "MarcaItem",
                column: "ID_MARCAITEM");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemCompra",
                table: "ItemCompra",
                column: "ID_ITEMCOMPRA");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "ID_ITEM");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FormaPagto",
                table: "FormaPagto",
                column: "ID_FORMAPAGTO");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empresa",
                table: "Empresa",
                column: "ID_EMPRESA");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DescontoItem",
                table: "DescontoItem",
                column: "ID_DESCONTOITEM");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Consumidor",
                table: "Consumidor",
                column: "ID_CONSUMIDOR");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CondPagto",
                table: "CondPagto",
                column: "ID_CONDPAGTO");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Compra",
                table: "Compra",
                column: "ID_COMPRA");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CondPagtoParcs",
                table: "CondPagtoParcs",
                column: "ID_CONDPAGTOPARCS");

            migrationBuilder.CreateIndex(
                name: "IX_Renda_EmpresaId",
                table: "Renda",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_MetaItem_MetaId",
                table: "MetaItem",
                column: "MetaId");

            migrationBuilder.CreateIndex(
                name: "IX_Meta_ConsumidorId",
                table: "Meta",
                column: "ConsumidorId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCompra_CompraId",
                table: "ItemCompra",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_Despesa_ConsumidorId",
                table: "Despesa",
                column: "ConsumidorId");

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

            migrationBuilder.CreateIndex(
                name: "IX_CondPagtoParcs_CondPagtoId",
                table: "CondPagtoParcs",
                column: "CondPagtoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_CondPagto_CondPagtoId",
                table: "Compra",
                column: "CondPagtoId",
                principalTable: "CondPagto",
                principalColumn: "ID_CONDPAGTO");

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Empresa_EmpresaId",
                table: "Compra",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "ID_EMPRESA");

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_FormaPagto_FormaPagtoId",
                table: "Compra",
                column: "FormaPagtoId",
                principalTable: "FormaPagto",
                principalColumn: "ID_FORMAPAGTO");

            migrationBuilder.AddForeignKey(
                name: "FK_CondPagtoParcs_CondPagto_CondPagtoId",
                table: "CondPagtoParcs",
                column: "CondPagtoId",
                principalTable: "CondPagto",
                principalColumn: "ID_CONDPAGTO");

            migrationBuilder.AddForeignKey(
                name: "FK_DescontoItem_ItemCompra_CodigoItemCompra",
                table: "DescontoItem",
                column: "CodigoItemCompra",
                principalTable: "ItemCompra",
                principalColumn: "ID_ITEMCOMPRA",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Despesa_CondPagto_CondPagtoId",
                table: "Despesa",
                column: "CondPagtoId",
                principalTable: "CondPagto",
                principalColumn: "ID_CONDPAGTO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Despesa_Consumidor_ConsumidorId",
                table: "Despesa",
                column: "ConsumidorId",
                principalTable: "Consumidor",
                principalColumn: "ID_CONSUMIDOR",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Despesa_Empresa_EmpresaId",
                table: "Despesa",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "ID_EMPRESA");

            migrationBuilder.AddForeignKey(
                name: "FK_Despesa_FormaPagto_FormaPagtoId",
                table: "Despesa",
                column: "FormaPagtoId",
                principalTable: "FormaPagto",
                principalColumn: "ID_FORMAPAGTO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemCompra_Compra_CompraId",
                table: "ItemCompra",
                column: "CompraId",
                principalTable: "Compra",
                principalColumn: "ID_COMPRA",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MarcaItem_Item_ItemId",
                table: "MarcaItem",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "ID_ITEM",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Meta_Consumidor_ConsumidorId",
                table: "Meta",
                column: "ConsumidorId",
                principalTable: "Consumidor",
                principalColumn: "ID_CONSUMIDOR",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MetaItem_Meta_MetaId",
                table: "MetaItem",
                column: "MetaId",
                principalTable: "Meta",
                principalColumn: "ID_META",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Renda_Consumidor_ConsumidorId",
                table: "Renda",
                column: "ConsumidorId",
                principalTable: "Consumidor",
                principalColumn: "ID_CONSUMIDOR",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Renda_Empresa_EmpresaId",
                table: "Renda",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "ID_EMPRESA");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compra_CondPagto_CondPagtoId",
                table: "Compra");

            migrationBuilder.DropForeignKey(
                name: "FK_Compra_Empresa_EmpresaId",
                table: "Compra");

            migrationBuilder.DropForeignKey(
                name: "FK_Compra_FormaPagto_FormaPagtoId",
                table: "Compra");

            migrationBuilder.DropForeignKey(
                name: "FK_CondPagtoParcs_CondPagto_CondPagtoId",
                table: "CondPagtoParcs");

            migrationBuilder.DropForeignKey(
                name: "FK_DescontoItem_ItemCompra_CodigoItemCompra",
                table: "DescontoItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Despesa_CondPagto_CondPagtoId",
                table: "Despesa");

            migrationBuilder.DropForeignKey(
                name: "FK_Despesa_Consumidor_ConsumidorId",
                table: "Despesa");

            migrationBuilder.DropForeignKey(
                name: "FK_Despesa_Empresa_EmpresaId",
                table: "Despesa");

            migrationBuilder.DropForeignKey(
                name: "FK_Despesa_FormaPagto_FormaPagtoId",
                table: "Despesa");

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

            migrationBuilder.DropForeignKey(
                name: "FK_Renda_Consumidor_ConsumidorId",
                table: "Renda");

            migrationBuilder.DropForeignKey(
                name: "FK_Renda_Empresa_EmpresaId",
                table: "Renda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Renda",
                table: "Renda");

            migrationBuilder.DropIndex(
                name: "IX_Renda_EmpresaId",
                table: "Renda");

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
                name: "PK_FormaPagto",
                table: "FormaPagto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empresa",
                table: "Empresa");

            migrationBuilder.DropIndex(
                name: "IX_Despesa_ConsumidorId",
                table: "Despesa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DescontoItem",
                table: "DescontoItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Consumidor",
                table: "Consumidor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CondPagto",
                table: "CondPagto");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_CondPagtoParcs",
                table: "CondPagtoParcs");

            migrationBuilder.DropIndex(
                name: "IX_CondPagtoParcs_CondPagtoId",
                table: "CondPagtoParcs");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Renda");

            migrationBuilder.DropColumn(
                name: "MetaId",
                table: "MetaItem");

            migrationBuilder.DropColumn(
                name: "ConsumidorId",
                table: "Meta");

            migrationBuilder.DropColumn(
                name: "CompraId",
                table: "ItemCompra");

            migrationBuilder.DropColumn(
                name: "ConsumidorId",
                table: "Despesa");

            migrationBuilder.DropColumn(
                name: "CondPagtoId",
                table: "Compra");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Compra");

            migrationBuilder.DropColumn(
                name: "FormaPagtoId",
                table: "Compra");

            migrationBuilder.DropColumn(
                name: "CondPagtoId",
                table: "CondPagtoParcs");

            migrationBuilder.RenameTable(
                name: "Renda",
                newName: "RENDA");

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
                name: "FormaPagto",
                newName: "FORMAPAGTO");

            migrationBuilder.RenameTable(
                name: "Empresa",
                newName: "EMPRESA");

            migrationBuilder.RenameTable(
                name: "DescontoItem",
                newName: "DESCONTOITEM");

            migrationBuilder.RenameTable(
                name: "Consumidor",
                newName: "CONSUMIDOR");

            migrationBuilder.RenameTable(
                name: "CondPagto",
                newName: "CONDPAGTO");

            migrationBuilder.RenameTable(
                name: "Compra",
                newName: "COMPRA");

            migrationBuilder.RenameTable(
                name: "CondPagtoParcs",
                newName: "CONDPAGTOPARC");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "RENDA",
                newName: "VALOR");

            migrationBuilder.RenameColumn(
                name: "Salario",
                table: "RENDA",
                newName: "SALARIO");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "RENDA",
                newName: "DESCRICAO");

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

            migrationBuilder.RenameColumn(
                name: "ID_RENDA",
                table: "RENDA",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Renda_ConsumidorId",
                table: "RENDA",
                newName: "IX_RENDA_ConsumidorId");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "METAITEM",
                newName: "STATUS");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "METAITEM",
                newName: "DESCRICAO");

            migrationBuilder.RenameColumn(
                name: "ValorReservaCompra",
                table: "METAITEM",
                newName: "VALOR_RESERVA_COMPRA");

            migrationBuilder.RenameColumn(
                name: "ValorGuardarMes",
                table: "METAITEM",
                newName: "VALOR_GUARDAR_MES");

            migrationBuilder.RenameColumn(
                name: "ValorCompra",
                table: "METAITEM",
                newName: "VALOR_COMPRA");

            migrationBuilder.RenameColumn(
                name: "LinkCompra",
                table: "METAITEM",
                newName: "LINK_COMPRA");

            migrationBuilder.RenameColumn(
                name: "DiferencaCompraReserva",
                table: "METAITEM",
                newName: "DIFERENCA_COMPRA_RESERVA");

            migrationBuilder.RenameColumn(
                name: "DataExpectativaAquisicao",
                table: "METAITEM",
                newName: "DATA_EXPECTATIVA_AQUISICAO");

            migrationBuilder.RenameColumn(
                name: "DATA_ALTERACAO",
                table: "METAITEM",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "CodigoMeta",
                table: "METAITEM",
                newName: "CODIGO_META");

            migrationBuilder.RenameColumn(
                name: "ID_METAITEM",
                table: "METAITEM",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "META",
                newName: "STATUS");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "META",
                newName: "DESCRICAO");

            migrationBuilder.RenameColumn(
                name: "ValorTotalGuardado",
                table: "META",
                newName: "VALOR_TOTAL_GUARDADO");

            migrationBuilder.RenameColumn(
                name: "ValorTotalCompra",
                table: "META",
                newName: "VALOR_TOTAL_COMPRA");

            migrationBuilder.RenameColumn(
                name: "DataIniVigencia",
                table: "META",
                newName: "DATA_INI_VIGENCIA");

            migrationBuilder.RenameColumn(
                name: "DataFimVigencia",
                table: "META",
                newName: "DATA_FIM_VIGENCIA");

            migrationBuilder.RenameColumn(
                name: "DATA_ALTERACAO",
                table: "META",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "ID_META",
                table: "META",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "MARCAITEM",
                newName: "DESCRICAO");

            migrationBuilder.RenameColumn(
                name: "DATA_ALTERACAO",
                table: "MARCAITEM",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "CodigoItem",
                table: "MARCAITEM",
                newName: "CODIGO_ITEM");

            migrationBuilder.RenameColumn(
                name: "ID_MARCAITEM",
                table: "MARCAITEM",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_MarcaItem_ItemId",
                table: "MARCAITEM",
                newName: "IX_MARCAITEM_ItemId");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "ITEMCOMPRA",
                newName: "DESCRICAO");

            migrationBuilder.RenameColumn(
                name: "ValorUnitario",
                table: "ITEMCOMPRA",
                newName: "VALOR_UNIT");

            migrationBuilder.RenameColumn(
                name: "ValorTotalItem",
                table: "ITEMCOMPRA",
                newName: "VALOR_TOTAL_ITEM");

            migrationBuilder.RenameColumn(
                name: "SequencialItem",
                table: "ITEMCOMPRA",
                newName: "SEQ_ITEM");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "ITEMCOMPRA",
                newName: "QUANT");

            migrationBuilder.RenameColumn(
                name: "DATA_ALTERACAO",
                table: "ITEMCOMPRA",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "CodigoDesconto",
                table: "ITEMCOMPRA",
                newName: "CODIGO_DESCONTO");

            migrationBuilder.RenameColumn(
                name: "CodigoCompra",
                table: "ITEMCOMPRA",
                newName: "CODIGO_COMPRA");

            migrationBuilder.RenameColumn(
                name: "ID_ITEMCOMPRA",
                table: "ITEMCOMPRA",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "ITEM",
                newName: "DESCRICAO");

            migrationBuilder.RenameColumn(
                name: "ID_ITEM",
                table: "ITEM",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "FORMAPAGTO",
                newName: "DESCRICAO");

            migrationBuilder.RenameColumn(
                name: "ID_FORMAPAGTO",
                table: "FORMAPAGTO",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Endereço",
                table: "EMPRESA",
                newName: "ENDEREÇO");

            migrationBuilder.RenameColumn(
                name: "Complemento",
                table: "EMPRESA",
                newName: "COMPLEMENTO");

            migrationBuilder.RenameColumn(
                name: "Cidade",
                table: "EMPRESA",
                newName: "CIDADE");

            migrationBuilder.RenameColumn(
                name: "Bairro",
                table: "EMPRESA",
                newName: "BAIRRO");

            migrationBuilder.RenameColumn(
                name: "NomeEmpresa",
                table: "EMPRESA",
                newName: "NOME_EMPRESA");

            migrationBuilder.RenameColumn(
                name: "CnpjEmpresa",
                table: "EMPRESA",
                newName: "CNPJ_EMPRESA");

            migrationBuilder.RenameColumn(
                name: "ID_EMPRESA",
                table: "EMPRESA",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ValorDesconto",
                table: "DESCONTOITEM",
                newName: "VALOR_DESCONTO");

            migrationBuilder.RenameColumn(
                name: "CodigoItemCompra",
                table: "DESCONTOITEM",
                newName: "ID_ITEM_COMPRA");

            migrationBuilder.RenameColumn(
                name: "ID_DESCONTOITEM",
                table: "DESCONTOITEM",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_DescontoItem_CodigoItemCompra",
                table: "DESCONTOITEM",
                newName: "IX_DESCONTOITEM_ID_ITEM_COMPRA");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "CONSUMIDOR",
                newName: "NOME");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "CONSUMIDOR",
                newName: "EMAIL");

            migrationBuilder.RenameColumn(
                name: "Celular",
                table: "CONSUMIDOR",
                newName: "CELULAR");

            migrationBuilder.RenameColumn(
                name: "RendaTotal",
                table: "CONSUMIDOR",
                newName: "RENDA_TOTAL");

            migrationBuilder.RenameColumn(
                name: "DataNascimento",
                table: "CONSUMIDOR",
                newName: "DATA_NASCIMENTO");

            migrationBuilder.RenameColumn(
                name: "DATA_ALTERACAO",
                table: "CONSUMIDOR",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "ID_CONSUMIDOR",
                table: "CONSUMIDOR",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "CONDPAGTO",
                newName: "DESCRICAO");

            migrationBuilder.RenameColumn(
                name: "Credito",
                table: "CONDPAGTO",
                newName: "CREDITO");

            migrationBuilder.RenameColumn(
                name: "QuantParc",
                table: "CONDPAGTO",
                newName: "QUANT_PARC");

            migrationBuilder.RenameColumn(
                name: "ID_CONDPAGTO",
                table: "CONDPAGTO",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "COMPRA",
                newName: "DESCRICAO");

            migrationBuilder.RenameColumn(
                name: "ValorTributos",
                table: "COMPRA",
                newName: "VALOR_TRIBUTOS");

            migrationBuilder.RenameColumn(
                name: "ValorTotalItens",
                table: "COMPRA",
                newName: "VALOR_TOTAL_ITENS");

            migrationBuilder.RenameColumn(
                name: "ValorTotalDescontos",
                table: "COMPRA",
                newName: "VALOR_TOTAL_DESCONTOS");

            migrationBuilder.RenameColumn(
                name: "ValorTotal",
                table: "COMPRA",
                newName: "VALOR_TOTAL");

            migrationBuilder.RenameColumn(
                name: "DataCompra",
                table: "COMPRA",
                newName: "DATA_COMPRA");

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

            migrationBuilder.RenameColumn(
                name: "ID_COMPRA",
                table: "COMPRA",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ValorParc",
                table: "CONDPAGTOPARC",
                newName: "VALOR_PARC");

            migrationBuilder.RenameColumn(
                name: "SeqParc",
                table: "CONDPAGTOPARC",
                newName: "SEQ_PARC");

            migrationBuilder.RenameColumn(
                name: "CodigoCondPagto",
                table: "CONDPAGTOPARC",
                newName: "ID_COND_PAGTO");

            migrationBuilder.RenameColumn(
                name: "ID_CONDPAGTOPARCS",
                table: "CONDPAGTOPARC",
                newName: "Id");

            migrationBuilder.AlterColumn<decimal>(
                name: "VALOR",
                table: "RENDA",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "ConsumidorId",
                table: "RENDA",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "RENDA",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP");

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

            migrationBuilder.AlterColumn<string>(
                name: "DESCRICAO",
                table: "METAITEM",
                type: "varchar",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<decimal>(
                name: "VALOR_RESERVA_COMPRA",
                table: "METAITEM",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<decimal>(
                name: "VALOR_GUARDAR_MES",
                table: "METAITEM",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<decimal>(
                name: "VALOR_COMPRA",
                table: "METAITEM",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<string>(
                name: "LINK_COMPRA",
                table: "METAITEM",
                type: "varchar",
                maxLength: 900,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DIFERENCA_COMPRA_RESERVA",
                table: "METAITEM",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_EXPECTATIVA_AQUISICAO",
                table: "METAITEM",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "METAITEM",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP");

            migrationBuilder.AlterColumn<int>(
                name: "CODIGO_META",
                table: "METAITEM",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "DESCRICAO",
                table: "META",
                type: "varchar",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<decimal>(
                name: "VALOR_TOTAL_GUARDADO",
                table: "META",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<decimal>(
                name: "VALOR_TOTAL_COMPRA",
                table: "META",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_INI_VIGENCIA",
                table: "META",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_FIM_VIGENCIA",
                table: "META",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "META",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP");

            migrationBuilder.AlterColumn<int>(
                name: "ItemId",
                table: "MARCAITEM",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "DESCRICAO",
                table: "MARCAITEM",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "MARCAITEM",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP");

            migrationBuilder.AlterColumn<int>(
                name: "CODIGO_ITEM",
                table: "MARCAITEM",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "DESCRICAO",
                table: "ITEMCOMPRA",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<decimal>(
                name: "VALOR_UNIT",
                table: "ITEMCOMPRA",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<decimal>(
                name: "VALOR_TOTAL_ITEM",
                table: "ITEMCOMPRA",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_ITEM",
                table: "ITEMCOMPRA",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "QUANT",
                table: "ITEMCOMPRA",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "ITEMCOMPRA",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP");

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

            migrationBuilder.AlterColumn<string>(
                name: "DESCRICAO",
                table: "ITEM",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "DESCRICAO",
                table: "FORMAPAGTO",
                type: "varchar",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "ENDEREÇO",
                table: "EMPRESA",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "COMPLEMENTO",
                table: "EMPRESA",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CIDADE",
                table: "EMPRESA",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BAIRRO",
                table: "EMPRESA",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOME_EMPRESA",
                table: "EMPRESA",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ_EMPRESA",
                table: "EMPRESA",
                type: "character varying(14)",
                maxLength: 14,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "VALOR_DESCONTO",
                table: "DESCONTOITEM",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "ID_ITEM_COMPRA",
                table: "DESCONTOITEM",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "NOME",
                table: "CONSUMIDOR",
                type: "character varying(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "EMAIL",
                table: "CONSUMIDOR",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "CELULAR",
                table: "CONSUMIDOR",
                type: "character varying(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RENDA_TOTAL",
                table: "CONSUMIDOR",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_NASCIMENTO",
                table: "CONSUMIDOR",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "CONSUMIDOR",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "DESCRICAO",
                table: "CONDPAGTO",
                type: "varchar",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "QUANT_PARC",
                table: "CONDPAGTO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "DESCRICAO",
                table: "COMPRA",
                type: "VARCHAR",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

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

            migrationBuilder.AlterColumn<decimal>(
                name: "VALOR_TRIBUTOS",
                table: "COMPRA",
                type: "numeric(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<decimal>(
                name: "VALOR_TOTAL_ITENS",
                table: "COMPRA",
                type: "numeric(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<decimal>(
                name: "VALOR_TOTAL_DESCONTOS",
                table: "COMPRA",
                type: "numeric(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<decimal>(
                name: "VALOR_TOTAL",
                table: "COMPRA",
                type: "numeric(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_COMPRA",
                table: "COMPRA",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "CODIGO_FORMA_PAGTO",
                table: "COMPRA",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CODIGO_EMPRESA",
                table: "COMPRA",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CODIGO_COND_PAGTO",
                table: "COMPRA",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "VALOR_PARC",
                table: "CONDPAGTOPARC",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_PARC",
                table: "CONDPAGTOPARC",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ID_COND_PAGTO",
                table: "CONDPAGTOPARC",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RENDA",
                table: "RENDA",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_METAITEM",
                table: "METAITEM",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_META",
                table: "META",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MARCAITEM",
                table: "MARCAITEM",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ITEMCOMPRA",
                table: "ITEMCOMPRA",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ITEM",
                table: "ITEM",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FORMAPAGTO",
                table: "FORMAPAGTO",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EMPRESA",
                table: "EMPRESA",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DESCONTOITEM",
                table: "DESCONTOITEM",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CONSUMIDOR",
                table: "CONSUMIDOR",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CONDPAGTO",
                table: "CONDPAGTO",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_COMPRA",
                table: "COMPRA",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CONDPAGTOPARC",
                table: "CONDPAGTOPARC",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_RENDA_CODIGO_CONSUMIDOR",
                table: "RENDA",
                column: "CODIGO_CONSUMIDOR");

            migrationBuilder.CreateIndex(
                name: "IX_RENDA_CODIGO_EMPRESA",
                table: "RENDA",
                column: "CODIGO_EMPRESA");

            migrationBuilder.CreateIndex(
                name: "IX_METAITEM_CODIGO_META",
                table: "METAITEM",
                column: "CODIGO_META");

            migrationBuilder.CreateIndex(
                name: "IX_META_CodigoConsumidor",
                table: "META",
                column: "CodigoConsumidor");

            migrationBuilder.CreateIndex(
                name: "IX_MARCAITEM_CODIGO_ITEM",
                table: "MARCAITEM",
                column: "CODIGO_ITEM");

            migrationBuilder.CreateIndex(
                name: "IX_ITEMCOMPRA_CODIGO_COMPRA",
                table: "ITEMCOMPRA",
                column: "CODIGO_COMPRA");

            migrationBuilder.CreateIndex(
                name: "IX_Despesa_CodigoConsumidor",
                table: "Despesa",
                column: "CodigoConsumidor");

            migrationBuilder.CreateIndex(
                name: "IX_COMPRA_CODIGO_COND_PAGTO",
                table: "COMPRA",
                column: "CODIGO_COND_PAGTO");

            migrationBuilder.CreateIndex(
                name: "IX_COMPRA_CODIGO_EMPRESA",
                table: "COMPRA",
                column: "CODIGO_EMPRESA");

            migrationBuilder.CreateIndex(
                name: "IX_COMPRA_CODIGO_FORMA_PAGTO",
                table: "COMPRA",
                column: "CODIGO_FORMA_PAGTO");

            migrationBuilder.CreateIndex(
                name: "IX_CONDPAGTOPARC_ID_COND_PAGTO",
                table: "CONDPAGTOPARC",
                column: "ID_COND_PAGTO");

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
                name: "FK_CONDPAGTOPARC_CONDPAGTO_ID_COND_PAGTO",
                table: "CONDPAGTOPARC",
                column: "ID_COND_PAGTO",
                principalTable: "CONDPAGTO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DESCONTOITEM_ITEMCOMPRA_ID_ITEM_COMPRA",
                table: "DESCONTOITEM",
                column: "ID_ITEM_COMPRA",
                principalTable: "ITEMCOMPRA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Despesa_CONDPAGTO_CondPagtoId",
                table: "Despesa",
                column: "CondPagtoId",
                principalTable: "CONDPAGTO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Despesa_CONSUMIDOR_CodigoConsumidor",
                table: "Despesa",
                column: "CodigoConsumidor",
                principalTable: "CONSUMIDOR",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Despesa_EMPRESA_EmpresaId",
                table: "Despesa",
                column: "EmpresaId",
                principalTable: "EMPRESA",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Despesa_FORMAPAGTO_FormaPagtoId",
                table: "Despesa",
                column: "FormaPagtoId",
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
                name: "FK_META_CONSUMIDOR_CodigoConsumidor",
                table: "META",
                column: "CodigoConsumidor",
                principalTable: "CONSUMIDOR",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_RENDA_CONSUMIDOR_ConsumidorId",
                table: "RENDA",
                column: "ConsumidorId",
                principalTable: "CONSUMIDOR",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RENDA_EMPRESA_CODIGO_EMPRESA",
                table: "RENDA",
                column: "CODIGO_EMPRESA",
                principalTable: "EMPRESA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
