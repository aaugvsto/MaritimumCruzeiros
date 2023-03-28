using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CruzeirosEmporio.Migrations
{
    public partial class MapDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TRIPULANTES_CABINES_ID_QUARTO",
                table: "TRIPULANTES");

            migrationBuilder.RenameColumn(
                name: "ID_QUARTO",
                table: "TRIPULANTES",
                newName: "ID_CABINE");

            migrationBuilder.RenameIndex(
                name: "IX_TRIPULANTES_ID_QUARTO",
                table: "TRIPULANTES",
                newName: "IX_TRIPULANTES_ID_CABINE");

            migrationBuilder.AlterColumn<int>(
                name: "ID_CABINE",
                table: "TRIPULANTES",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TRIPULANTES_CABINES_ID_CABINE",
                table: "TRIPULANTES",
                column: "ID_CABINE",
                principalTable: "CABINES",
                principalColumn: "ID_CABINE");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TRIPULANTES_CABINES_ID_CABINE",
                table: "TRIPULANTES");

            migrationBuilder.RenameColumn(
                name: "ID_CABINE",
                table: "TRIPULANTES",
                newName: "ID_QUARTO");

            migrationBuilder.RenameIndex(
                name: "IX_TRIPULANTES_ID_CABINE",
                table: "TRIPULANTES",
                newName: "IX_TRIPULANTES_ID_QUARTO");

            migrationBuilder.AlterColumn<int>(
                name: "ID_QUARTO",
                table: "TRIPULANTES",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TRIPULANTES_CABINES_ID_QUARTO",
                table: "TRIPULANTES",
                column: "ID_QUARTO",
                principalTable: "CABINES",
                principalColumn: "ID_CABINE",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
