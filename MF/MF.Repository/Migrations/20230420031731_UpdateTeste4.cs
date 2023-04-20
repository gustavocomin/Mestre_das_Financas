using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MF.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTeste4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID_MF.Domain.ControleMensal.Despesas.Despesa",
                table: "Despesa",
                newName: "ID_ID_DESPESA");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID_ID_DESPESA",
                table: "Despesa",
                newName: "ID_MF.Domain.ControleMensal.Despesas.Despesa");
        }
    }
}
