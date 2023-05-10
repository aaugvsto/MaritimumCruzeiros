using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaritimumCruzeiros.Migrations
{
    public partial class TransacaoAndPedidoTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PASSAGENS",
                columns: table => new
                {
                    ID_PASSAGEM = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CRUZEIRO_ID = table.Column<int>(type: "int", nullable: false),
                    EMAIL_PESSOA_COMPRADORA = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EMAIL_PESSOA_TITULAR = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NOME_TITULAR_PASSAGEN = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TitularCPF = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroPassaporte = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PASSAGENS", x => x.ID_PASSAGEM);
                    table.ForeignKey(
                        name: "FK_PASSAGENS_CRUZEIROS_CRUZEIRO_ID",
                        column: x => x.CRUZEIRO_ID,
                        principalTable: "CRUZEIROS",
                        principalColumn: "ID_CRUZEIRO",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TRANSACOES",
                columns: table => new
                {
                    ID_TRANSACAO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EMAIL_CLIENTE = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NUMEROS_FINAIS_CARTAO = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TIPO_CARTAO = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NUMERO_PARCELAS = table.Column<int>(type: "int", nullable: true),
                    RESULTADO_TRANSACAO = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VALOR_TOTAL = table.Column<double>(type: "double", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRANSACOES", x => x.ID_TRANSACAO);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_PASSAGENS_CRUZEIRO_ID",
                table: "PASSAGENS",
                column: "CRUZEIRO_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PASSAGENS");

            migrationBuilder.DropTable(
                name: "TRANSACOES");
        }
    }
}
