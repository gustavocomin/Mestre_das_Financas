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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    Credito = table.Column<bool>(type: "boolean", nullable: false),
                    QuantParc = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondPagto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Consumidor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RendaTotal = table.Column<decimal>(type: "numeric", nullable: false),
                    Celular = table.Column<string>(type: "text", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumidor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
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
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormaPagto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descricao = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPagto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descricao = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CondPagtoParcs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CodigoCondPagto = table.Column<int>(type: "integer", nullable: false),
                    ValorParc = table.Column<decimal>(type: "numeric", nullable: false),
                    SeqParc = table.Column<int>(type: "integer", nullable: false),
                    CondPagtoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondPagtoParcs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CondPagtoParcs_CondPagto_CondPagtoId",
                        column: x => x.CondPagtoId,
                        principalTable: "CondPagto",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Meta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    DataIniVigencia = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DataFimVigencia = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ValorTotalCompra = table.Column<decimal>(type: "numeric", nullable: false),
                    ValorTotalGuardado = table.Column<decimal>(type: "numeric", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    CodigoConsumidor = table.Column<int>(type: "integer", nullable: false),
                    ConsumidorId = table.Column<int>(type: "integer", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meta_Consumidor_ConsumidorId",
                        column: x => x.ConsumidorId,
                        principalTable: "Consumidor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RENDA",
                columns: table => new
                {
                    IdRENDA = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descricao = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Valor = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Salario = table.Column<bool>(type: "boolean", nullable: false),
                    CodigoEmpresa = table.Column<int>(type: "integer", nullable: true),
                    CodigoConsumidor = table.Column<int>(type: "integer", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RENDA", x => x.IdRENDA);
                    table.ForeignKey(
                        name: "FK_DESPESA_CONSUMIDOR",
                        column: x => x.CodigoConsumidor,
                        principalTable: "Consumidor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RENDA_Empresa_CodigoEmpresa",
                        column: x => x.CodigoEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Compra",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
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
                    table.PrimaryKey("PK_Compra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compra_CondPagto_CondPagtoId",
                        column: x => x.CondPagtoId,
                        principalTable: "CondPagto",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Compra_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Compra_FormaPagto_FormaPagtoId",
                        column: x => x.FormaPagtoId,
                        principalTable: "FormaPagto",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Despesa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    Valor = table.Column<decimal>(type: "numeric", nullable: false),
                    TipoDespesa = table.Column<int>(type: "integer", nullable: false),
                    DataDespesa = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Mensal = table.Column<bool>(type: "boolean", nullable: false),
                    DataInicial = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DataFinal = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CodigoEmpresa = table.Column<int>(type: "integer", nullable: true),
                    CodigoConsumidor = table.Column<int>(type: "integer", nullable: false),
                    CodigoFormaPagto = table.Column<int>(type: "integer", nullable: false),
                    CodigoCondPagto = table.Column<int>(type: "integer", nullable: false),
                    FormaPagtoId = table.Column<int>(type: "integer", nullable: false),
                    CondPagtoId = table.Column<int>(type: "integer", nullable: false),
                    ConsumidorId = table.Column<int>(type: "integer", nullable: false),
                    EmpresaId = table.Column<int>(type: "integer", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Despesa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Despesa_CondPagto_CondPagtoId",
                        column: x => x.CondPagtoId,
                        principalTable: "CondPagto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Despesa_Consumidor_ConsumidorId",
                        column: x => x.ConsumidorId,
                        principalTable: "Consumidor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Despesa_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Despesa_FormaPagto_FormaPagtoId",
                        column: x => x.FormaPagtoId,
                        principalTable: "FormaPagto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MarcaItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    CodigoItem = table.Column<int>(type: "integer", nullable: false),
                    ItemId = table.Column<int>(type: "integer", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcaItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarcaItem_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MetaItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
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
                    DataAlteracao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetaItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MetaItem_Meta_MetaId",
                        column: x => x.MetaId,
                        principalTable: "Meta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemCompra",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CodigoCompra = table.Column<int>(type: "integer", nullable: false),
                    SequencialItem = table.Column<int>(type: "integer", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    Quantidade = table.Column<decimal>(type: "numeric", nullable: false),
                    ValorUnitario = table.Column<decimal>(type: "numeric", nullable: false),
                    ValorTotalItem = table.Column<decimal>(type: "numeric", nullable: false),
                    CodigoDesconto = table.Column<int>(type: "integer", nullable: true),
                    CompraId = table.Column<int>(type: "integer", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCompra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemCompra_Compra_CompraId",
                        column: x => x.CompraId,
                        principalTable: "Compra",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DescontoItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CodigoItemCompra = table.Column<int>(type: "integer", nullable: false),
                    ValorDesconto = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescontoItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DescontoItem_ItemCompra_CodigoItemCompra",
                        column: x => x.CodigoItemCompra,
                        principalTable: "ItemCompra",
                        principalColumn: "Id",
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
                name: "IX_Despesa_CondPagtoId",
                table: "Despesa",
                column: "CondPagtoId");

            migrationBuilder.CreateIndex(
                name: "IX_Despesa_ConsumidorId",
                table: "Despesa",
                column: "ConsumidorId");

            migrationBuilder.CreateIndex(
                name: "IX_Despesa_EmpresaId",
                table: "Despesa",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Despesa_FormaPagtoId",
                table: "Despesa",
                column: "FormaPagtoId");

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
                name: "IX_RENDA_CodigoConsumidor",
                table: "RENDA",
                column: "CodigoConsumidor");

            migrationBuilder.CreateIndex(
                name: "IX_RENDA_CodigoEmpresa",
                table: "RENDA",
                column: "CodigoEmpresa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CondPagtoParcs");

            migrationBuilder.DropTable(
                name: "DescontoItem");

            migrationBuilder.DropTable(
                name: "Despesa");

            migrationBuilder.DropTable(
                name: "MarcaItem");

            migrationBuilder.DropTable(
                name: "MetaItem");

            migrationBuilder.DropTable(
                name: "RENDA");

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
