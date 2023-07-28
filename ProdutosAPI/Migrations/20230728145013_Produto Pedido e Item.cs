using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProdutosAPI.Migrations
{
    /// <inheritdoc />
    public partial class ProdutoPedidoeItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    pedidoId = table.Column<int>(type: "int", nullable: false),
                    produtoId = table.Column<int>(type: "int", nullable: false),
                    qtd_pedido = table.Column<int>(type: "int", nullable: false),
                    valor_item = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => new { x.pedidoId, x.produtoId });
                    table.ForeignKey(
                        name: "FK_Items_Pedidos_pedidoId",
                        column: x => x.pedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Produtos_produtoId",
                        column: x => x.produtoId,
                        principalTable: "Produtos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Items_produtoId",
                table: "Items",
                column: "produtoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
