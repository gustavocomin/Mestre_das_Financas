using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MF.Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CondPagto",
                columns: table => new
                {
                    ID_CONDPAGTO = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    Credito = table.Column<bool>(type: "boolean", nullable: false),
                    QuantParc = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondPagto", x => x.ID_CONDPAGTO);
                });

            migrationBuilder.CreateTable(
                name: "Consumidor",
                columns: table => new
                {
                    ID_CONSUMIDOR = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RendaTotal = table.Column<decimal>(type: "numeric", nullable: false),
                    Celular = table.Column<string>(type: "text", nullable: true),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumidor", x => x.ID_CONSUMIDOR);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    ID_EMPRESA = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    NomeEmpresa = table.Column<string>(type: "text", nullable: false),
                    CnpjEmpresa = table.Column<string>(type: "text", nullable: true),
                    Endereço = table.Column<string>(type: "text", nullable: true),
                    Bairro = table.Column<string>(type: "text", nullable: true),
                    Cidade = table.Column<string>(type: "text", nullable: true),
                    Complemento = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.ID_EMPRESA);
                });

            migrationBuilder.CreateTable(
                name: "FormaPagto",
                columns: table => new
                {
                    ID_FORMAPAGTO = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descricao = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPagto", x => x.ID_FORMAPAGTO);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ID_ITEM = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descricao = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ID_ITEM);
                });

            migrationBuilder.CreateTable(
                name: "CondPagtoParcs",
                columns: table => new
                {
                    ID_CONDPAGTOPARCS = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CodigoCondPagto = table.Column<int>(type: "integer", nullable: false),
                    ValorParc = table.Column<decimal>(type: "numeric", nullable: false),
                    SeqParc = table.Column<int>(type: "integer", nullable: false),
                    CondPagtoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondPagtoParcs", x => x.ID_CONDPAGTOPARCS);
                    table.ForeignKey(
                        name: "FK_CondPagtoParcs_CondPagto_CondPagtoId",
                        column: x => x.CondPagtoId,
                        principalTable: "CondPagto",
                        principalColumn: "ID_CONDPAGTO");
                });

            migrationBuilder.CreateTable(
                name: "Meta",
                columns: table => new
                {
                    ID_META = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    DataIniVigencia = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DataFimVigencia = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ValorTotalCompra = table.Column<decimal>(type: "numeric", nullable: false),
                    ValorTotalGuardado = table.Column<decimal>(type: "numeric", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    CodigoConsumidor = table.Column<int>(type: "integer", nullable: false),
                    ConsumidorId = table.Column<int>(type: "integer", nullable: false),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meta", x => x.ID_META);
                    table.ForeignKey(
                        name: "FK_Meta_Consumidor_ConsumidorId",
                        column: x => x.ConsumidorId,
                        principalTable: "Consumidor",
                        principalColumn: "ID_CONSUMIDOR",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Renda",
                columns: table => new
                {
                    ID_RENDA = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descricao = table.Column<int>(type: "integer", nullable: false),
                    Valor = table.Column<decimal>(type: "numeric", nullable: false),
                    Salario = table.Column<bool>(type: "boolean", nullable: false),
                    CodigoEmpresa = table.Column<int>(type: "integer", nullable: true),
                    CodigoConsumidor = table.Column<int>(type: "integer", nullable: false),
                    EmpresaId = table.Column<int>(type: "integer", nullable: true),
                    ConsumidorId = table.Column<int>(type: "integer", nullable: false),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Renda", x => x.ID_RENDA);
                    table.ForeignKey(
                        name: "FK_Renda_Consumidor_ConsumidorId",
                        column: x => x.ConsumidorId,
                        principalTable: "Consumidor",
                        principalColumn: "ID_CONSUMIDOR",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Renda_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "ID_EMPRESA");
                });

            migrationBuilder.CreateTable(
                name: "Compra",
                columns: table => new
                {
                    ID_COMPRA = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    DataCompra = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "numeric", nullable: false),
                    ValorTotalItens = table.Column<decimal>(type: "numeric", nullable: false),
                    ValorTotalDescontos = table.Column<decimal>(type: "numeric", nullable: false),
                    ValorTributos = table.Column<decimal>(type: "numeric", nullable: false),
                    COO = table.Column<string>(type: "text", nullable: true),
                    CCF = table.Column<string>(type: "text", nullable: true),
                    CodigoFormaPagto = table.Column<int>(type: "integer", nullable: true),
                    CodigoCondPagto = table.Column<int>(type: "integer", nullable: true),
                    CodigoEmpresa = table.Column<int>(type: "integer", nullable: true),
                    EmpresaId = table.Column<int>(type: "integer", nullable: true),
                    FormaPagtoId = table.Column<int>(type: "integer", nullable: true),
                    CondPagtoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra", x => x.ID_COMPRA);
                    table.ForeignKey(
                        name: "FK_Compra_CondPagto_CondPagtoId",
                        column: x => x.CondPagtoId,
                        principalTable: "CondPagto",
                        principalColumn: "ID_CONDPAGTO");
                    table.ForeignKey(
                        name: "FK_Compra_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "ID_EMPRESA");
                    table.ForeignKey(
                        name: "FK_Compra_FormaPagto_FormaPagtoId",
                        column: x => x.FormaPagtoId,
                        principalTable: "FormaPagto",
                        principalColumn: "ID_FORMAPAGTO");
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
                    CODIGO_EMPRESA = table.Column<int>(type: "int", nullable: false),
                    CODIGO_CONSUMIDOR = table.Column<int>(type: "int", nullable: false),
                    CODIGO_FORMA_PAGTO = table.Column<int>(type: "int", nullable: false),
                    CODIGO_COND_PAGTO = table.Column<int>(type: "int", nullable: false),
                    ConsumidorId = table.Column<int>(type: "integer", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DESPESA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DESPESA_CONSUMIDOR",
                        column: x => x.CODIGO_CONSUMIDOR,
                        principalTable: "Consumidor",
                        principalColumn: "ID_CONSUMIDOR",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DESPESA_CondPagto_CODIGO_COND_PAGTO",
                        column: x => x.CODIGO_COND_PAGTO,
                        principalTable: "CondPagto",
                        principalColumn: "ID_CONDPAGTO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DESPESA_Consumidor_ConsumidorId",
                        column: x => x.ConsumidorId,
                        principalTable: "Consumidor",
                        principalColumn: "ID_CONSUMIDOR");
                    table.ForeignKey(
                        name: "FK_DESPESA_Empresa_CODIGO_EMPRESA",
                        column: x => x.CODIGO_EMPRESA,
                        principalTable: "Empresa",
                        principalColumn: "ID_EMPRESA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DESPESA_FormaPagto_CODIGO_FORMA_PAGTO",
                        column: x => x.CODIGO_FORMA_PAGTO,
                        principalTable: "FormaPagto",
                        principalColumn: "ID_FORMAPAGTO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MarcaItem",
                columns: table => new
                {
                    ID_MARCAITEM = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    CodigoItem = table.Column<int>(type: "integer", nullable: false),
                    ItemId = table.Column<int>(type: "integer", nullable: false),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcaItem", x => x.ID_MARCAITEM);
                    table.ForeignKey(
                        name: "FK_MarcaItem_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "ID_ITEM",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MetaItem",
                columns: table => new
                {
                    ID_METAITEM = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    ValorCompra = table.Column<decimal>(type: "numeric", nullable: false),
                    LinkCompra = table.Column<string>(type: "text", nullable: true),
                    ValorReservaCompra = table.Column<decimal>(type: "numeric", nullable: false),
                    DiferencaCompraReserva = table.Column<decimal>(type: "numeric", nullable: false),
                    DataExpectativaAquisicao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ValorGuardarMes = table.Column<decimal>(type: "numeric", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    CodigoMeta = table.Column<int>(type: "integer", nullable: false),
                    MetaId = table.Column<int>(type: "integer", nullable: false),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetaItem", x => x.ID_METAITEM);
                    table.ForeignKey(
                        name: "FK_MetaItem_Meta_MetaId",
                        column: x => x.MetaId,
                        principalTable: "Meta",
                        principalColumn: "ID_META",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemCompra",
                columns: table => new
                {
                    ID_ITEMCOMPRA = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CodigoCompra = table.Column<int>(type: "integer", nullable: false),
                    SequencialItem = table.Column<int>(type: "integer", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    Quantidade = table.Column<decimal>(type: "numeric", nullable: false),
                    ValorUnitario = table.Column<decimal>(type: "numeric", nullable: false),
                    ValorTotalItem = table.Column<decimal>(type: "numeric", nullable: false),
                    CodigoDesconto = table.Column<int>(type: "integer", nullable: true),
                    CompraId = table.Column<int>(type: "integer", nullable: false),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCompra", x => x.ID_ITEMCOMPRA);
                    table.ForeignKey(
                        name: "FK_ItemCompra_Compra_CompraId",
                        column: x => x.CompraId,
                        principalTable: "Compra",
                        principalColumn: "ID_COMPRA",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DescontoItem",
                columns: table => new
                {
                    ID_DESCONTOITEM = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CodigoItemCompra = table.Column<int>(type: "integer", nullable: false),
                    ValorDesconto = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescontoItem", x => x.ID_DESCONTOITEM);
                    table.ForeignKey(
                        name: "FK_DescontoItem_ItemCompra_CodigoItemCompra",
                        column: x => x.CodigoItemCompra,
                        principalTable: "ItemCompra",
                        principalColumn: "ID_ITEMCOMPRA",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compra_CondPagtoId",
                table: "Compra",
                column: "CondPagtoId");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_EmpresaId",
                table: "Compra",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_FormaPagtoId",
                table: "Compra",
                column: "FormaPagtoId");

            migrationBuilder.CreateIndex(
                name: "IX_CondPagtoParcs_CondPagtoId",
                table: "CondPagtoParcs",
                column: "CondPagtoId");

            migrationBuilder.CreateIndex(
                name: "IX_DescontoItem_CodigoItemCompra",
                table: "DescontoItem",
                column: "CodigoItemCompra",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DESPESA_CODIGO_COND_PAGTO",
                table: "DESPESA",
                column: "CODIGO_COND_PAGTO");

            migrationBuilder.CreateIndex(
                name: "IX_DESPESA_CODIGO_CONSUMIDOR",
                table: "DESPESA",
                column: "CODIGO_CONSUMIDOR");

            migrationBuilder.CreateIndex(
                name: "IX_DESPESA_CODIGO_EMPRESA",
                table: "DESPESA",
                column: "CODIGO_EMPRESA");

            migrationBuilder.CreateIndex(
                name: "IX_DESPESA_CODIGO_FORMA_PAGTO",
                table: "DESPESA",
                column: "CODIGO_FORMA_PAGTO");

            migrationBuilder.CreateIndex(
                name: "IX_DESPESA_ConsumidorId",
                table: "DESPESA",
                column: "ConsumidorId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCompra_CompraId",
                table: "ItemCompra",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_MarcaItem_ItemId",
                table: "MarcaItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Meta_ConsumidorId",
                table: "Meta",
                column: "ConsumidorId");

            migrationBuilder.CreateIndex(
                name: "IX_MetaItem_MetaId",
                table: "MetaItem",
                column: "MetaId");

            migrationBuilder.CreateIndex(
                name: "IX_Renda_ConsumidorId",
                table: "Renda",
                column: "ConsumidorId");

            migrationBuilder.CreateIndex(
                name: "IX_Renda_EmpresaId",
                table: "Renda",
                column: "EmpresaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CondPagtoParcs");

            migrationBuilder.DropTable(
                name: "DescontoItem");

            migrationBuilder.DropTable(
                name: "DESPESA");

            migrationBuilder.DropTable(
                name: "MarcaItem");

            migrationBuilder.DropTable(
                name: "MetaItem");

            migrationBuilder.DropTable(
                name: "Renda");

            migrationBuilder.DropTable(
                name: "ItemCompra");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Meta");

            migrationBuilder.DropTable(
                name: "Compra");

            migrationBuilder.DropTable(
                name: "Consumidor");

            migrationBuilder.DropTable(
                name: "CondPagto");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "FormaPagto");
        }
    }
}
