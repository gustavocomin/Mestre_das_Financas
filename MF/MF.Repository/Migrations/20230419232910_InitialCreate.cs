using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MF.Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CONDPAGTO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DESCRICAO = table.Column<string>(type: "varchar", maxLength: 20, nullable: false),
                    CREDITO = table.Column<bool>(type: "boolean", nullable: false),
                    QUANT_PARC = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONDPAGTO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CONSUMIDOR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    NOME = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    EMAIL = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    DATA_NASCIMENTO = table.Column<DateTime>(type: "date", nullable: true),
                    RENDA_TOTAL = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    CELULAR = table.Column<string>(type: "character varying(12)", maxLength: 12, nullable: true),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONSUMIDOR", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EMPRESA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    NOME_EMPRESA = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CNPJ_EMPRESA = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: true),
                    ENDEREÇO = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    BAIRRO = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    CIDADE = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    COMPLEMENTO = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPRESA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FORMAPAGTO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DESCRICAO = table.Column<string>(type: "varchar", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FORMAPAGTO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ITEM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DESCRICAO = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MARCAITEM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DESCRICAO = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MARCAITEM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CONDPAGTOPARC",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ID_COND_PAGTO = table.Column<int>(type: "int", nullable: false),
                    VALOR_PARC = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    SEQ_PARC = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONDPAGTOPARC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CONDPAGTOPARC_CONDPAGTO_ID_COND_PAGTO",
                        column: x => x.ID_COND_PAGTO,
                        principalTable: "CONDPAGTO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "META",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DESCRICAO = table.Column<string>(type: "varchar", maxLength: 100, nullable: false),
                    DATA_INI_VIGENCIA = table.Column<DateTime>(type: "date", nullable: true),
                    DATA_FIM_VIGENCIA = table.Column<DateTime>(type: "date", nullable: true),
                    VALOR_TOTAL_COMPRA = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    VALOR_TOTAL_GUARDADO = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    STATUS = table.Column<int>(type: "integer", nullable: false),
                    CodigoConsumidor = table.Column<int>(type: "integer", nullable: false),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_META", x => x.Id);
                    table.ForeignKey(
                        name: "FK_META_CONSUMIDOR_CodigoConsumidor",
                        column: x => x.CodigoConsumidor,
                        principalTable: "CONSUMIDOR",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RENDA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DESCRICAO = table.Column<int>(type: "integer", maxLength: 100, nullable: false),
                    VALOR = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    SALARIO = table.Column<bool>(type: "boolean", nullable: false),
                    CodigoEmpresa = table.Column<int>(type: "integer", nullable: true),
                    CodigoConsumidor = table.Column<int>(type: "integer", nullable: false),
                    ConsumidorId = table.Column<int>(type: "integer", nullable: true),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RENDA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RENDA_CONSUMIDOR_CodigoConsumidor",
                        column: x => x.CodigoConsumidor,
                        principalTable: "CONSUMIDOR",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RENDA_CONSUMIDOR_ConsumidorId",
                        column: x => x.ConsumidorId,
                        principalTable: "CONSUMIDOR",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RENDA_EMPRESA_CodigoEmpresa",
                        column: x => x.CodigoEmpresa,
                        principalTable: "EMPRESA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "COMPRA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DESCRICAO = table.Column<string>(type: "VARCHAR", maxLength: 50, nullable: false),
                    DATA_COMPRA = table.Column<DateTime>(type: "date", nullable: false),
                    VALOR_TOTAL = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    VALOR_TOTAL_ITENS = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    VALOR_TOTAL_DESCONTOS = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    VALOR_TRIBUTOS = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    COO = table.Column<string>(type: "VARCHAR", maxLength: 50, nullable: true),
                    CCF = table.Column<string>(type: "VARCHAR", maxLength: 50, nullable: true),
                    CodigoFormaPagto = table.Column<int>(type: "integer", nullable: false),
                    CodigoCondPagto = table.Column<int>(type: "integer", nullable: false),
                    CodigoEmpresa = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPRA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_COMPRA_CONDPAGTO_CodigoCondPagto",
                        column: x => x.CodigoCondPagto,
                        principalTable: "CONDPAGTO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_COMPRA_EMPRESA_CodigoEmpresa",
                        column: x => x.CodigoEmpresa,
                        principalTable: "EMPRESA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_COMPRA_FORMAPAGTO_CodigoFormaPagto",
                        column: x => x.CodigoFormaPagto,
                        principalTable: "FORMAPAGTO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DESPESA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DESCRICAO = table.Column<string>(type: "varchar", maxLength: 100, nullable: false),
                    VALOR = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    TIPO_DESPESA = table.Column<int>(type: "integer", nullable: false),
                    DATA_DESPESA = table.Column<DateTime>(type: "date", nullable: false),
                    MENSAL = table.Column<bool>(type: "boolean", nullable: false),
                    DATA_INICIAL = table.Column<DateTime>(type: "date", nullable: true),
                    DATA_FINAL = table.Column<DateTime>(type: "date", nullable: true),
                    CodigoEmpresa = table.Column<int>(type: "integer", nullable: false),
                    CodigoConsumidor = table.Column<int>(type: "integer", nullable: false),
                    CodigoFormaPagto = table.Column<int>(type: "integer", nullable: false),
                    CodigoCondPagto = table.Column<int>(type: "integer", nullable: false),
                    ConsumidorId = table.Column<int>(type: "integer", nullable: true),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DESPESA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DESPESA_CONDPAGTO_CodigoCondPagto",
                        column: x => x.CodigoCondPagto,
                        principalTable: "CONDPAGTO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DESPESA_CONSUMIDOR_CodigoConsumidor",
                        column: x => x.CodigoConsumidor,
                        principalTable: "CONSUMIDOR",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DESPESA_CONSUMIDOR_ConsumidorId",
                        column: x => x.ConsumidorId,
                        principalTable: "CONSUMIDOR",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DESPESA_EMPRESA_CodigoEmpresa",
                        column: x => x.CodigoEmpresa,
                        principalTable: "EMPRESA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DESPESA_FORMAPAGTO_CodigoFormaPagto",
                        column: x => x.CodigoFormaPagto,
                        principalTable: "FORMAPAGTO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MetaItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DESCRICAO = table.Column<string>(type: "varchar", maxLength: 200, nullable: false),
                    VALOR_COMPRA = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    LINK_COMPRA = table.Column<string>(type: "varchar", maxLength: 900, nullable: true),
                    VALOR_RESERVA_COMPRA = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    DIFERENCA_COMPRA_RESERVA = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    DATA_EXPECTATIVA_AQUISICAO = table.Column<DateTime>(type: "date", nullable: false),
                    VALOR_GUARDAR_MES = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    STATUS = table.Column<int>(type: "integer", nullable: false),
                    CodigoMeta = table.Column<int>(type: "integer", nullable: false),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetaItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MetaItem_META_CodigoMeta",
                        column: x => x.CodigoMeta,
                        principalTable: "META",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ITEMCOMPRA",
                columns: table => new
                {
                    ID_COMPRA = table.Column<int>(type: "integer", nullable: false),
                    SEQ_ITEM = table.Column<int>(type: "integer", nullable: false),
                    DESCRICAO = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    QUANT = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    VALOR_UNIT = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    VALOR_TOTAL_ITEM = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    CodigoDesconto = table.Column<int>(type: "integer", nullable: true),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEMCOMPRA", x => x.ID_COMPRA);
                    table.ForeignKey(
                        name: "FK_ITEMCOMPRA_COMPRA_ID_COMPRA",
                        column: x => x.ID_COMPRA,
                        principalTable: "COMPRA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DESCONTOITEM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ID_ITEM_COMPRA = table.Column<int>(type: "int", nullable: false),
                    VALOR_DESCONTO = table.Column<decimal>(type: "numeric(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DESCONTOITEM", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DESCONTOITEM_ITEMCOMPRA_ID_ITEM_COMPRA",
                        column: x => x.ID_ITEM_COMPRA,
                        principalTable: "ITEMCOMPRA",
                        principalColumn: "ID_COMPRA",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_COMPRA_CodigoCondPagto",
                table: "COMPRA",
                column: "CodigoCondPagto");

            migrationBuilder.CreateIndex(
                name: "IX_COMPRA_CodigoEmpresa",
                table: "COMPRA",
                column: "CodigoEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_COMPRA_CodigoFormaPagto",
                table: "COMPRA",
                column: "CodigoFormaPagto");

            migrationBuilder.CreateIndex(
                name: "IX_CONDPAGTOPARC_ID_COND_PAGTO",
                table: "CONDPAGTOPARC",
                column: "ID_COND_PAGTO");

            migrationBuilder.CreateIndex(
                name: "IX_DESCONTOITEM_ID_ITEM_COMPRA",
                table: "DESCONTOITEM",
                column: "ID_ITEM_COMPRA",
                unique: true);

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
                name: "IX_DESPESA_ConsumidorId",
                table: "DESPESA",
                column: "ConsumidorId");

            migrationBuilder.CreateIndex(
                name: "IX_META_CodigoConsumidor",
                table: "META",
                column: "CodigoConsumidor");

            migrationBuilder.CreateIndex(
                name: "IX_MetaItem_CodigoMeta",
                table: "MetaItem",
                column: "CodigoMeta");

            migrationBuilder.CreateIndex(
                name: "IX_RENDA_CodigoConsumidor",
                table: "RENDA",
                column: "CodigoConsumidor");

            migrationBuilder.CreateIndex(
                name: "IX_RENDA_CodigoEmpresa",
                table: "RENDA",
                column: "CodigoEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_RENDA_ConsumidorId",
                table: "RENDA",
                column: "ConsumidorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CONDPAGTOPARC");

            migrationBuilder.DropTable(
                name: "DESCONTOITEM");

            migrationBuilder.DropTable(
                name: "DESPESA");

            migrationBuilder.DropTable(
                name: "ITEM");

            migrationBuilder.DropTable(
                name: "MARCAITEM");

            migrationBuilder.DropTable(
                name: "MetaItem");

            migrationBuilder.DropTable(
                name: "RENDA");

            migrationBuilder.DropTable(
                name: "ITEMCOMPRA");

            migrationBuilder.DropTable(
                name: "META");

            migrationBuilder.DropTable(
                name: "COMPRA");

            migrationBuilder.DropTable(
                name: "CONSUMIDOR");

            migrationBuilder.DropTable(
                name: "CONDPAGTO");

            migrationBuilder.DropTable(
                name: "EMPRESA");

            migrationBuilder.DropTable(
                name: "FORMAPAGTO");
        }
    }
}
