using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MF.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTablenameMetaItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MetaItem_META_CodigoMeta",
                table: "MetaItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MetaItem",
                table: "MetaItem");

            migrationBuilder.RenameTable(
                name: "MetaItem",
                newName: "METAITEM");

            migrationBuilder.RenameIndex(
                name: "IX_MetaItem_CodigoMeta",
                table: "METAITEM",
                newName: "IX_METAITEM_CodigoMeta");

            migrationBuilder.AddPrimaryKey(
                name: "PK_METAITEM",
                table: "METAITEM",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_METAITEM_META_CodigoMeta",
                table: "METAITEM",
                column: "CodigoMeta",
                principalTable: "META",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_METAITEM_META_CodigoMeta",
                table: "METAITEM");

            migrationBuilder.DropPrimaryKey(
                name: "PK_METAITEM",
                table: "METAITEM");

            migrationBuilder.RenameTable(
                name: "METAITEM",
                newName: "MetaItem");

            migrationBuilder.RenameIndex(
                name: "IX_METAITEM_CodigoMeta",
                table: "MetaItem",
                newName: "IX_MetaItem_CodigoMeta");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MetaItem",
                table: "MetaItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MetaItem_META_CodigoMeta",
                table: "MetaItem",
                column: "CodigoMeta",
                principalTable: "META",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
