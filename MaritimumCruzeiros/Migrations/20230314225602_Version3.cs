using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CruzeirosEmporio.Migrations
{
    public partial class Version3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TRIPULANTE_Quartos_QuartoId",
                table: "TRIPULANTE");

            migrationBuilder.RenameColumn(
                name: "QuartoId",
                table: "TRIPULANTE",
                newName: "ID_QUARTO");

            migrationBuilder.RenameIndex(
                name: "IX_TRIPULANTE_QuartoId",
                table: "TRIPULANTE",
                newName: "IX_TRIPULANTE_ID_QUARTO");

            migrationBuilder.AlterColumn<int>(
                name: "ID_QUARTO",
                table: "TRIPULANTE",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TRIPULANTE_Quartos_ID_QUARTO",
                table: "TRIPULANTE",
                column: "ID_QUARTO",
                principalTable: "Quartos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TRIPULANTE_Quartos_ID_QUARTO",
                table: "TRIPULANTE");

            migrationBuilder.RenameColumn(
                name: "ID_QUARTO",
                table: "TRIPULANTE",
                newName: "QuartoId");

            migrationBuilder.RenameIndex(
                name: "IX_TRIPULANTE_ID_QUARTO",
                table: "TRIPULANTE",
                newName: "IX_TRIPULANTE_QuartoId");

            migrationBuilder.AlterColumn<int>(
                name: "QuartoId",
                table: "TRIPULANTE",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TRIPULANTE_Quartos_QuartoId",
                table: "TRIPULANTE",
                column: "QuartoId",
                principalTable: "Quartos",
                principalColumn: "Id");
        }
    }
}
