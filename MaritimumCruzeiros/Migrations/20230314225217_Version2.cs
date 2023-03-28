using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CruzeirosEmporio.Migrations
{
    public partial class Version2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TRIPULANTE_Cruzeiros_CruzeiroId",
                table: "TRIPULANTE");

            migrationBuilder.DropForeignKey(
                name: "FK_TRIPULANTE_Quartos_ID_QUARTO",
                table: "TRIPULANTE");

            migrationBuilder.RenameColumn(
                name: "ID_QUARTO",
                table: "TRIPULANTE",
                newName: "QuartoId");

            migrationBuilder.RenameColumn(
                name: "CruzeiroId",
                table: "TRIPULANTE",
                newName: "ID_CRUZEIRO");

            migrationBuilder.RenameIndex(
                name: "IX_TRIPULANTE_ID_QUARTO",
                table: "TRIPULANTE",
                newName: "IX_TRIPULANTE_QuartoId");

            migrationBuilder.RenameIndex(
                name: "IX_TRIPULANTE_CruzeiroId",
                table: "TRIPULANTE",
                newName: "IX_TRIPULANTE_ID_CRUZEIRO");

            migrationBuilder.AlterColumn<string>(
                name: "DOCUMENTO",
                table: "TRIPULANTE",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "QuartoId",
                table: "TRIPULANTE",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ID_CRUZEIRO",
                table: "TRIPULANTE",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TRIPULANTE_Cruzeiros_ID_CRUZEIRO",
                table: "TRIPULANTE",
                column: "ID_CRUZEIRO",
                principalTable: "Cruzeiros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TRIPULANTE_Quartos_QuartoId",
                table: "TRIPULANTE",
                column: "QuartoId",
                principalTable: "Quartos",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TRIPULANTE_Cruzeiros_ID_CRUZEIRO",
                table: "TRIPULANTE");

            migrationBuilder.DropForeignKey(
                name: "FK_TRIPULANTE_Quartos_QuartoId",
                table: "TRIPULANTE");

            migrationBuilder.RenameColumn(
                name: "QuartoId",
                table: "TRIPULANTE",
                newName: "ID_QUARTO");

            migrationBuilder.RenameColumn(
                name: "ID_CRUZEIRO",
                table: "TRIPULANTE",
                newName: "CruzeiroId");

            migrationBuilder.RenameIndex(
                name: "IX_TRIPULANTE_QuartoId",
                table: "TRIPULANTE",
                newName: "IX_TRIPULANTE_ID_QUARTO");

            migrationBuilder.RenameIndex(
                name: "IX_TRIPULANTE_ID_CRUZEIRO",
                table: "TRIPULANTE",
                newName: "IX_TRIPULANTE_CruzeiroId");

            migrationBuilder.AlterColumn<int>(
                name: "DOCUMENTO",
                table: "TRIPULANTE",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ID_QUARTO",
                table: "TRIPULANTE",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CruzeiroId",
                table: "TRIPULANTE",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TRIPULANTE_Cruzeiros_CruzeiroId",
                table: "TRIPULANTE",
                column: "CruzeiroId",
                principalTable: "Cruzeiros",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TRIPULANTE_Quartos_ID_QUARTO",
                table: "TRIPULANTE",
                column: "ID_QUARTO",
                principalTable: "Quartos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
