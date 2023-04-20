using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MF.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTeste2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DESPESA_CONDPAGTO_CODIGO_COND_PAGTO",
                table: "DESPESA");

            migrationBuilder.DropForeignKey(
                name: "FK_DESPESA_CONSUMIDOR_CODIGO_CONSUMIDOR",
                table: "DESPESA");

            migrationBuilder.DropForeignKey(
                name: "FK_DESPESA_CONSUMIDOR_ConsumidorId",
                table: "DESPESA");

            migrationBuilder.DropForeignKey(
                name: "FK_DESPESA_EMPRESA_CODIGO_EMPRESA",
                table: "DESPESA");

            migrationBuilder.DropForeignKey(
                name: "FK_DESPESA_FORMAPAGTO_CODIGO_FORMA_PAGTO",
                table: "DESPESA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DESPESA",
                table: "DESPESA");

            migrationBuilder.DropIndex(
                name: "IX_DESPESA_CODIGO_COND_PAGTO",
                table: "DESPESA");

            migrationBuilder.DropIndex(
                name: "IX_DESPESA_CODIGO_EMPRESA",
                table: "DESPESA");

            migrationBuilder.DropIndex(
                name: "IX_DESPESA_CODIGO_FORMA_PAGTO",
                table: "DESPESA");

            migrationBuilder.RenameTable(
                name: "DESPESA",
                newName: "Despesa");

            migrationBuilder.RenameColumn(
                name: "VALOR",
                table: "Despesa",
                newName: "Valor");

            migrationBuilder.RenameColumn(
                name: "MENSAL",
                table: "Despesa",
                newName: "Mensal");

            migrationBuilder.RenameColumn(
                name: "DESCRICAO",
                table: "Despesa",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "TIPO_DESPESA",
                table: "Despesa",
                newName: "TipoDespesa");

            migrationBuilder.RenameColumn(
                name: "DATA_INICIAL",
                table: "Despesa",
                newName: "DataInicial");

            migrationBuilder.RenameColumn(
                name: "DATA_FINAL",
                table: "Despesa",
                newName: "DataFinal");

            migrationBuilder.RenameColumn(
                name: "DATA_DESPESA",
                table: "Despesa",
                newName: "DataDespesa");

            migrationBuilder.RenameColumn(
                name: "CODIGO_FORMA_PAGTO",
                table: "Despesa",
                newName: "CodigoFormaPagto");

            migrationBuilder.RenameColumn(
                name: "CODIGO_EMPRESA",
                table: "Despesa",
                newName: "CodigoEmpresa");

            migrationBuilder.RenameColumn(
                name: "CODIGO_CONSUMIDOR",
                table: "Despesa",
                newName: "CodigoConsumidor");

            migrationBuilder.RenameColumn(
                name: "CODIGO_COND_PAGTO",
                table: "Despesa",
                newName: "CodigoCondPagto");

            migrationBuilder.RenameColumn(
                name: "ID_DESPESA",
                table: "Despesa",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ConsumidorId",
                table: "Despesa",
                newName: "EmpresaId");

            migrationBuilder.RenameIndex(
                name: "IX_DESPESA_ConsumidorId",
                table: "Despesa",
                newName: "IX_Despesa_EmpresaId");

            migrationBuilder.RenameIndex(
                name: "IX_DESPESA_CODIGO_CONSUMIDOR",
                table: "Despesa",
                newName: "IX_Despesa_CodigoConsumidor");

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
                name: "FormaPagtoId",
                table: "Despesa",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Despesa",
                table: "Despesa",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Despesa_CondPagtoId",
                table: "Despesa",
                column: "CondPagtoId");

            migrationBuilder.CreateIndex(
                name: "IX_Despesa_FormaPagtoId",
                table: "Despesa",
                column: "FormaPagtoId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Despesa",
                table: "Despesa");

            migrationBuilder.DropIndex(
                name: "IX_Despesa_CondPagtoId",
                table: "Despesa");

            migrationBuilder.DropIndex(
                name: "IX_Despesa_FormaPagtoId",
                table: "Despesa");

            migrationBuilder.DropColumn(
                name: "CondPagtoId",
                table: "Despesa");

            migrationBuilder.DropColumn(
                name: "FormaPagtoId",
                table: "Despesa");

            migrationBuilder.RenameTable(
                name: "Despesa",
                newName: "DESPESA");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "DESPESA",
                newName: "VALOR");

            migrationBuilder.RenameColumn(
                name: "Mensal",
                table: "DESPESA",
                newName: "MENSAL");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "DESPESA",
                newName: "DESCRICAO");

            migrationBuilder.RenameColumn(
                name: "TipoDespesa",
                table: "DESPESA",
                newName: "TIPO_DESPESA");

            migrationBuilder.RenameColumn(
                name: "DataInicial",
                table: "DESPESA",
                newName: "DATA_INICIAL");

            migrationBuilder.RenameColumn(
                name: "DataFinal",
                table: "DESPESA",
                newName: "DATA_FINAL");

            migrationBuilder.RenameColumn(
                name: "DataDespesa",
                table: "DESPESA",
                newName: "DATA_DESPESA");

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

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DESPESA",
                newName: "ID_DESPESA");

            migrationBuilder.RenameColumn(
                name: "EmpresaId",
                table: "DESPESA",
                newName: "ConsumidorId");

            migrationBuilder.RenameIndex(
                name: "IX_Despesa_EmpresaId",
                table: "DESPESA",
                newName: "IX_DESPESA_ConsumidorId");

            migrationBuilder.RenameIndex(
                name: "IX_Despesa_CodigoConsumidor",
                table: "DESPESA",
                newName: "IX_DESPESA_CODIGO_CONSUMIDOR");

            migrationBuilder.AlterColumn<decimal>(
                name: "VALOR",
                table: "DESPESA",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<string>(
                name: "DESCRICAO",
                table: "DESPESA",
                type: "varchar",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_INICIAL",
                table: "DESPESA",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_FINAL",
                table: "DESPESA",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_DESPESA",
                table: "DESPESA",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

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
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_DESPESA",
                table: "DESPESA",
                column: "ID_DESPESA");

            migrationBuilder.CreateIndex(
                name: "IX_DESPESA_CODIGO_COND_PAGTO",
                table: "DESPESA",
                column: "CODIGO_COND_PAGTO");

            migrationBuilder.CreateIndex(
                name: "IX_DESPESA_CODIGO_EMPRESA",
                table: "DESPESA",
                column: "CODIGO_EMPRESA");

            migrationBuilder.CreateIndex(
                name: "IX_DESPESA_CODIGO_FORMA_PAGTO",
                table: "DESPESA",
                column: "CODIGO_FORMA_PAGTO");

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
                name: "FK_DESPESA_CONSUMIDOR_ConsumidorId",
                table: "DESPESA",
                column: "ConsumidorId",
                principalTable: "CONSUMIDOR",
                principalColumn: "Id");

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
        }
    }
}
