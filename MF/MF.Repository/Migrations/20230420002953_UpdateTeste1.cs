using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MF.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTeste1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "DESPESA",
                newName: "DATA_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DESPESA",
                newName: "ID_DESPESA");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_ALTERACAO",
                table: "DESPESA",
                type: "TIMESTAMP",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DATA_ALTERACAO",
                table: "DESPESA",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "ID_DESPESA",
                table: "DESPESA",
                newName: "Id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "DESPESA",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP");
        }
    }
}
