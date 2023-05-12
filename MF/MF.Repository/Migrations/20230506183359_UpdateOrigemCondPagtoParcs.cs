using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MF.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOrigemCondPagtoParcs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CodigoOrigem",
                table: "CONDPAGTOPARC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Origem",
                table: "CONDPAGTOPARC",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodigoOrigem",
                table: "CONDPAGTOPARC");

            migrationBuilder.DropColumn(
                name: "Origem",
                table: "CONDPAGTOPARC");
        }
    }
}
