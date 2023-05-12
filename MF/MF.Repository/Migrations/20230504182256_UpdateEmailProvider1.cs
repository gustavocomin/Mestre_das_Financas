using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MF.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmailProvider1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UsuarioAlteracao",
                table: "EmailProvider",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsuarioAlteracao",
                table: "EmailProvider");
        }
    }
}
