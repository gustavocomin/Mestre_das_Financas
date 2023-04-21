using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MF.Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdRENDA",
                table: "RENDA",
                newName: "IdRenda");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdRenda",
                table: "RENDA",
                newName: "IdRENDA");
        }
    }
}
