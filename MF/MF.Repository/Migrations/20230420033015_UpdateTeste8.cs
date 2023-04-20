﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MF.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTeste8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "Despesa",
                newName: "DATA_ALTERACAO");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_ALTERACAO",
                table: "Despesa",
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
                table: "Despesa",
                newName: "DataAlteracao");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "Despesa",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP");
        }
    }
}