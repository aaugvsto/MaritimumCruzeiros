using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CruzeirosEmporio.Migrations
{
    public partial class DBRemap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TRIPULANTES_CABINES_ID_CABINE",
                table: "TRIPULANTES");

            migrationBuilder.RenameColumn(
                name: "ID_CABINE",
                table: "TRIPULANTES",
                newName: "ID_CABINE_TRIPULANTE");

            migrationBuilder.RenameIndex(
                name: "IX_TRIPULANTES_ID_CABINE",
                table: "TRIPULANTES",
                newName: "IX_TRIPULANTES_ID_CABINE_TRIPULANTE");

            migrationBuilder.CreateTable(
                name: "CABINE_TRIPULANTE",
                columns: table => new
                {
                    ID_CABINE_TRIPULANTE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CABINE = table.Column<int>(type: "int", nullable: false),
                    ID_TRIPULANTE = table.Column<int>(type: "int", nullable: false),
                    ID_CRUZEIRO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CABINE_TRIPULANTE", x => x.ID_CABINE_TRIPULANTE);
                    table.ForeignKey(
                        name: "FK_CABINE_TRIPULANTE_CABINES_ID_CABINE",
                        column: x => x.ID_CABINE,
                        principalTable: "CABINES",
                        principalColumn: "ID_CABINE",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CABINE_TRIPULANTE_CRUZEIROS_ID_CRUZEIRO",
                        column: x => x.ID_CRUZEIRO,
                        principalTable: "CRUZEIROS",
                        principalColumn: "ID_CRUZEIRO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CABINE_TRIPULANTE_TRIPULANTES_ID_TRIPULANTE",
                        column: x => x.ID_TRIPULANTE,
                        principalTable: "TRIPULANTES",
                        principalColumn: "ID_TRIPULANTE",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CABINE_TRIPULANTE_ID_CABINE",
                table: "CABINE_TRIPULANTE",
                column: "ID_CABINE");

            migrationBuilder.CreateIndex(
                name: "IX_CABINE_TRIPULANTE_ID_CRUZEIRO",
                table: "CABINE_TRIPULANTE",
                column: "ID_CRUZEIRO");

            migrationBuilder.CreateIndex(
                name: "IX_CABINE_TRIPULANTE_ID_TRIPULANTE",
                table: "CABINE_TRIPULANTE",
                column: "ID_TRIPULANTE");

            migrationBuilder.AddForeignKey(
                name: "FK_TRIPULANTES_CABINE_TRIPULANTE_ID_CABINE_TRIPULANTE",
                table: "TRIPULANTES",
                column: "ID_CABINE_TRIPULANTE",
                principalTable: "CABINE_TRIPULANTE",
                principalColumn: "ID_CABINE_TRIPULANTE");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TRIPULANTES_CABINE_TRIPULANTE_ID_CABINE_TRIPULANTE",
                table: "TRIPULANTES");

            migrationBuilder.DropTable(
                name: "CABINE_TRIPULANTE");

            migrationBuilder.RenameColumn(
                name: "ID_CABINE_TRIPULANTE",
                table: "TRIPULANTES",
                newName: "ID_CABINE");

            migrationBuilder.RenameIndex(
                name: "IX_TRIPULANTES_ID_CABINE_TRIPULANTE",
                table: "TRIPULANTES",
                newName: "IX_TRIPULANTES_ID_CABINE");

            migrationBuilder.AddForeignKey(
                name: "FK_TRIPULANTES_CABINES_ID_CABINE",
                table: "TRIPULANTES",
                column: "ID_CABINE",
                principalTable: "CABINES",
                principalColumn: "ID_CABINE");
        }
    }
}
