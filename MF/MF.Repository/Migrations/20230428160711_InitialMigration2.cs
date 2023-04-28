using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MF.Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_RENDA_Empresa_CodigoEmpresa",
                table: "RENDA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FormaPagto",
                table: "FormaPagto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empresa",
                table: "Empresa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Despesa",
                table: "Despesa");

            migrationBuilder.DropIndex(
                name: "IX_Despesa_CondPagtoId",
                table: "Despesa");

            migrationBuilder.DropIndex(
                name: "IX_Despesa_EmpresaId",
                table: "Despesa");

            migrationBuilder.DropIndex(
                name: "IX_Despesa_FormaPagtoId",
                table: "Despesa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CondPagto",
                table: "CondPagto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CondPagtoParcs",
                table: "CondPagtoParcs");

            migrationBuilder.DropIndex(
                name: "IX_CondPagtoParcs_CondPagtoId",
                table: "CondPagtoParcs");

            migrationBuilder.DropColumn(
                name: "CondPagtoId",
                table: "Despesa");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Despesa");

            migrationBuilder.DropColumn(
                name: "FormaPagtoId",
                table: "Despesa");

            migrationBuilder.DropColumn(
                name: "CondPagtoId",
                table: "CondPagtoParcs");

            migrationBuilder.RenameTable(
                name: "FormaPagto",
                newName: "FORMAPAGTO");

            migrationBuilder.RenameTable(
                name: "Empresa",
                newName: "EMPRESA");

            migrationBuilder.RenameTable(
                name: "Despesa",
                newName: "DESPESA");

            migrationBuilder.RenameTable(
                name: "CondPagto",
                newName: "CONDPAGTO");

            migrationBuilder.RenameTable(
                name: "CondPagtoParcs",
                newName: "CONDPAGTOPARC");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "FORMAPAGTO",
                newName: "IdFormaPagto");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "EMPRESA",
                newName: "IdEmpresa");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DESPESA",
                newName: "IdDespesa");

            migrationBuilder.RenameIndex(
                name: "IX_Despesa_ConsumidorId",
                table: "DESPESA",
                newName: "IX_DESPESA_ConsumidorId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Consumidor",
                newName: "IdConsumidor");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CONDPAGTO",
                newName: "IdCondPagto");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CONDPAGTOPARC",
                newName: "IdCondPagtoParcs");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "FORMAPAGTO",
                type: "varchar",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "NomeEmpresa",
                table: "EMPRESA",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Endereço",
                table: "EMPRESA",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "EMPRESA",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CnpjEmpresa",
                table: "EMPRESA",
                type: "character varying(14)",
                maxLength: 14,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "EMPRESA",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "EMPRESA",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "DESPESA",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "DESPESA",
                type: "varchar",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInicial",
                table: "DESPESA",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataFinal",
                table: "DESPESA",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDespesa",
                table: "DESPESA",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "DESPESA",
                type: "TIMESTAMP",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "ConsumidorId",
                table: "DESPESA",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoFormaPagto",
                table: "DESPESA",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoEmpresa",
                table: "DESPESA",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CodigoConsumidor",
                table: "DESPESA",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoCondPagto",
                table: "DESPESA",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "RendaTotal",
                table: "Consumidor",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Consumidor",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimento",
                table: "Consumidor",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "Consumidor",
                type: "TIMESTAMP",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Celular",
                table: "Consumidor",
                type: "character varying(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "QuantParc",
                table: "CONDPAGTO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "CONDPAGTO",
                type: "varchar",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorParc",
                table: "CONDPAGTOPARC",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "SeqParc",
                table: "CONDPAGTOPARC",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoCondPagto",
                table: "CONDPAGTOPARC",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FORMAPAGTO",
                table: "FORMAPAGTO",
                column: "IdFormaPagto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EMPRESA",
                table: "EMPRESA",
                column: "IdEmpresa");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DESPESA",
                table: "DESPESA",
                column: "IdDespesa");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CONDPAGTO",
                table: "CONDPAGTO",
                column: "IdCondPagto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CONDPAGTOPARC",
                table: "CONDPAGTOPARC",
                column: "IdCondPagtoParcs");

            migrationBuilder.CreateIndex(
                name: "IX_DESPESA_CodigoCondPagto",
                table: "DESPESA",
                column: "CodigoCondPagto");

            migrationBuilder.CreateIndex(
                name: "IX_DESPESA_CodigoConsumidor",
                table: "DESPESA",
                column: "CodigoConsumidor");

            migrationBuilder.CreateIndex(
                name: "IX_DESPESA_CodigoEmpresa",
                table: "DESPESA",
                column: "CodigoEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_DESPESA_CodigoFormaPagto",
                table: "DESPESA",
                column: "CodigoFormaPagto");

            migrationBuilder.CreateIndex(
                name: "IX_CONDPAGTOPARC_CodigoCondPagto",
                table: "CONDPAGTOPARC",
                column: "CodigoCondPagto");

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
                name: "FK_CONDPAGTOPARC_CONDPAGTO_CodigoCondPagto",
                table: "CONDPAGTOPARC",
                column: "CodigoCondPagto",
                principalTable: "CONDPAGTO",
                principalColumn: "IdCondPagto",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DESPESA_CONDPAGTO_CodigoCondPagto",
                table: "DESPESA",
                column: "CodigoCondPagto",
                principalTable: "CONDPAGTO",
                principalColumn: "IdCondPagto",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DESPESA_Consumidor_CodigoConsumidor",
                table: "DESPESA",
                column: "CodigoConsumidor",
                principalTable: "Consumidor",
                principalColumn: "IdConsumidor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DESPESA_Consumidor_ConsumidorId",
                table: "DESPESA",
                column: "ConsumidorId",
                principalTable: "Consumidor",
                principalColumn: "IdConsumidor");

            migrationBuilder.AddForeignKey(
                name: "FK_DESPESA_EMPRESA_CodigoEmpresa",
                table: "DESPESA",
                column: "CodigoEmpresa",
                principalTable: "EMPRESA",
                principalColumn: "IdEmpresa",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DESPESA_FORMAPAGTO_CodigoFormaPagto",
                table: "DESPESA",
                column: "CodigoFormaPagto",
                principalTable: "FORMAPAGTO",
                principalColumn: "IdFormaPagto",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RENDA_EMPRESA_CodigoEmpresa",
                table: "RENDA",
                column: "CodigoEmpresa",
                principalTable: "EMPRESA",
                principalColumn: "IdEmpresa",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_CONDPAGTOPARC_CONDPAGTO_CodigoCondPagto",
                table: "CONDPAGTOPARC");

            migrationBuilder.DropForeignKey(
                name: "FK_DESPESA_CONDPAGTO_CodigoCondPagto",
                table: "DESPESA");

            migrationBuilder.DropForeignKey(
                name: "FK_DESPESA_Consumidor_CodigoConsumidor",
                table: "DESPESA");

            migrationBuilder.DropForeignKey(
                name: "FK_DESPESA_Consumidor_ConsumidorId",
                table: "DESPESA");

            migrationBuilder.DropForeignKey(
                name: "FK_DESPESA_EMPRESA_CodigoEmpresa",
                table: "DESPESA");

            migrationBuilder.DropForeignKey(
                name: "FK_DESPESA_FORMAPAGTO_CodigoFormaPagto",
                table: "DESPESA");

            migrationBuilder.DropForeignKey(
                name: "FK_RENDA_EMPRESA_CodigoEmpresa",
                table: "RENDA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FORMAPAGTO",
                table: "FORMAPAGTO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EMPRESA",
                table: "EMPRESA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DESPESA",
                table: "DESPESA");

            migrationBuilder.DropIndex(
                name: "IX_DESPESA_CodigoCondPagto",
                table: "DESPESA");

            migrationBuilder.DropIndex(
                name: "IX_DESPESA_CodigoConsumidor",
                table: "DESPESA");

            migrationBuilder.DropIndex(
                name: "IX_DESPESA_CodigoEmpresa",
                table: "DESPESA");

            migrationBuilder.DropIndex(
                name: "IX_DESPESA_CodigoFormaPagto",
                table: "DESPESA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CONDPAGTO",
                table: "CONDPAGTO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CONDPAGTOPARC",
                table: "CONDPAGTOPARC");

            migrationBuilder.DropIndex(
                name: "IX_CONDPAGTOPARC_CodigoCondPagto",
                table: "CONDPAGTOPARC");

            migrationBuilder.RenameTable(
                name: "FORMAPAGTO",
                newName: "FormaPagto");

            migrationBuilder.RenameTable(
                name: "EMPRESA",
                newName: "Empresa");

            migrationBuilder.RenameTable(
                name: "DESPESA",
                newName: "Despesa");

            migrationBuilder.RenameTable(
                name: "CONDPAGTO",
                newName: "CondPagto");

            migrationBuilder.RenameTable(
                name: "CONDPAGTOPARC",
                newName: "CondPagtoParcs");

            migrationBuilder.RenameColumn(
                name: "IdFormaPagto",
                table: "FormaPagto",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdEmpresa",
                table: "Empresa",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdDespesa",
                table: "Despesa",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_DESPESA_ConsumidorId",
                table: "Despesa",
                newName: "IX_Despesa_ConsumidorId");

            migrationBuilder.RenameColumn(
                name: "IdConsumidor",
                table: "Consumidor",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdCondPagto",
                table: "CondPagto",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdCondPagtoParcs",
                table: "CondPagtoParcs",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "FormaPagto",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "NomeEmpresa",
                table: "Empresa",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

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
                name: "CnpjEmpresa",
                table: "Empresa",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(14)",
                oldMaxLength: 14,
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

            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "Despesa",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Despesa",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInicial",
                table: "Despesa",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataFinal",
                table: "Despesa",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDespesa",
                table: "Despesa",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "Despesa",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP");

            migrationBuilder.AlterColumn<int>(
                name: "ConsumidorId",
                table: "Despesa",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CodigoFormaPagto",
                table: "Despesa",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoEmpresa",
                table: "Despesa",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoConsumidor",
                table: "Despesa",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoCondPagto",
                table: "Despesa",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CondPagtoId",
                table: "Despesa",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "Despesa",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FormaPagtoId",
                table: "Despesa",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "RendaTotal",
                table: "Consumidor",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Consumidor",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimento",
                table: "Consumidor",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "Consumidor",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "Celular",
                table: "Consumidor",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "QuantParc",
                table: "CondPagto",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "CondPagto",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 20);

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
                name: "PK_FormaPagto",
                table: "FormaPagto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empresa",
                table: "Empresa",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Despesa",
                table: "Despesa",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CondPagto",
                table: "CondPagto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CondPagtoParcs",
                table: "CondPagtoParcs",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Despesa_CondPagtoId",
                table: "Despesa",
                column: "CondPagtoId");

            migrationBuilder.CreateIndex(
                name: "IX_Despesa_EmpresaId",
                table: "Despesa",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Despesa_FormaPagtoId",
                table: "Despesa",
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
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Empresa_EmpresaId",
                table: "Compra",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_FormaPagto_FormaPagtoId",
                table: "Compra",
                column: "FormaPagtoId",
                principalTable: "FormaPagto",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CondPagtoParcs_CondPagto_CondPagtoId",
                table: "CondPagtoParcs",
                column: "CondPagtoId",
                principalTable: "CondPagto",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Despesa_CondPagto_CondPagtoId",
                table: "Despesa",
                column: "CondPagtoId",
                principalTable: "CondPagto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Despesa_Consumidor_ConsumidorId",
                table: "Despesa",
                column: "ConsumidorId",
                principalTable: "Consumidor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Despesa_Empresa_EmpresaId",
                table: "Despesa",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Despesa_FormaPagto_FormaPagtoId",
                table: "Despesa",
                column: "FormaPagtoId",
                principalTable: "FormaPagto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RENDA_Empresa_CodigoEmpresa",
                table: "RENDA",
                column: "CodigoEmpresa",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
