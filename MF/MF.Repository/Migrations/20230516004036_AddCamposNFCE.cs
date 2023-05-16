using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MF.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddCamposNFCE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UnidadeCompra",
                table: "ItemCompra",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "CnpjEmpresa",
                table: "EMPRESA",
                type: "character varying(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(14)",
                oldMaxLength: 14,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkNF",
                table: "Compra",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumeroNF",
                table: "Compra",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorTotalNF",
                table: "Compra",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnidadeCompra",
                table: "ItemCompra");

            migrationBuilder.DropColumn(
                name: "LinkNF",
                table: "Compra");

            migrationBuilder.DropColumn(
                name: "NumeroNF",
                table: "Compra");

            migrationBuilder.DropColumn(
                name: "ValorTotalNF",
                table: "Compra");

            migrationBuilder.AlterColumn<string>(
                name: "CnpjEmpresa",
                table: "EMPRESA",
                type: "character varying(14)",
                maxLength: 14,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15,
                oldNullable: true);
        }
    }
}
