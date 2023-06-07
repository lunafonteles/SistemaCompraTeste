using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaCompra.API.Migrations
{
    public partial class solicitacaoCompra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CondicaoPagamento",
                table: "SolicitacaoCompra");

            migrationBuilder.DropColumn(
                name: "TotalGeral",
                table: "SolicitacaoCompra");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CondicaoPagamento",
                table: "SolicitacaoCompra",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalGeral",
                table: "SolicitacaoCompra",
                type: "decimal(18,2)",
                nullable: true);
        }
    }
}
