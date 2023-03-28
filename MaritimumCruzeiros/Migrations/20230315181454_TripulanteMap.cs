using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CruzeirosEmporio.Migrations
{
    public partial class TripulanteMap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tripulantes_Cruzeiros_CruzeiroId",
                table: "Tripulantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Tripulantes_Quartos_QuartoId",
                table: "Tripulantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Tripulantes_SexoTripulante_SexoTripulanteId",
                table: "Tripulantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Tripulantes_TipoTripulante_TipoTripulanteId",
                table: "Tripulantes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tripulantes",
                table: "Tripulantes");

            migrationBuilder.RenameTable(
                name: "Tripulantes",
                newName: "TRIPULANTE");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "TRIPULANTE",
                newName: "NOME");

            migrationBuilder.RenameColumn(
                name: "Idade",
                table: "TRIPULANTE",
                newName: "IDADE");

            migrationBuilder.RenameColumn(
                name: "Documento",
                table: "TRIPULANTE",
                newName: "DOCUMENTO");

            migrationBuilder.RenameColumn(
                name: "TipoTripulanteId",
                table: "TRIPULANTE",
                newName: "ID_TIPO_TRIPULANTE");

            migrationBuilder.RenameColumn(
                name: "SexoTripulanteId",
                table: "TRIPULANTE",
                newName: "ID_SEXO");

            migrationBuilder.RenameColumn(
                name: "QuartoId",
                table: "TRIPULANTE",
                newName: "ID_QUARTO");

            migrationBuilder.RenameColumn(
                name: "CruzeiroId",
                table: "TRIPULANTE",
                newName: "ID_CRUZEIRO");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TRIPULANTE",
                newName: "ID_TRIPULANTE");

            migrationBuilder.RenameIndex(
                name: "IX_Tripulantes_TipoTripulanteId",
                table: "TRIPULANTE",
                newName: "IX_TRIPULANTE_ID_TIPO_TRIPULANTE");

            migrationBuilder.RenameIndex(
                name: "IX_Tripulantes_SexoTripulanteId",
                table: "TRIPULANTE",
                newName: "IX_TRIPULANTE_ID_SEXO");

            migrationBuilder.RenameIndex(
                name: "IX_Tripulantes_QuartoId",
                table: "TRIPULANTE",
                newName: "IX_TRIPULANTE_ID_QUARTO");

            migrationBuilder.RenameIndex(
                name: "IX_Tripulantes_CruzeiroId",
                table: "TRIPULANTE",
                newName: "IX_TRIPULANTE_ID_CRUZEIRO");

            migrationBuilder.AlterColumn<string>(
                name: "NOME",
                table: "TRIPULANTE",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DOCUMENTO",
                table: "TRIPULANTE",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID_QUARTO",
                table: "TRIPULANTE",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ID_CRUZEIRO",
                table: "TRIPULANTE",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TRIPULANTE",
                table: "TRIPULANTE",
                column: "ID_TRIPULANTE");

            migrationBuilder.AddForeignKey(
                name: "FK_TRIPULANTE_Cruzeiros_ID_CRUZEIRO",
                table: "TRIPULANTE",
                column: "ID_CRUZEIRO",
                principalTable: "Cruzeiros",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TRIPULANTE_Quartos_ID_QUARTO",
                table: "TRIPULANTE",
                column: "ID_QUARTO",
                principalTable: "Quartos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TRIPULANTE_SexoTripulante_ID_SEXO",
                table: "TRIPULANTE",
                column: "ID_SEXO",
                principalTable: "SexoTripulante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TRIPULANTE_TipoTripulante_ID_TIPO_TRIPULANTE",
                table: "TRIPULANTE",
                column: "ID_TIPO_TRIPULANTE",
                principalTable: "TipoTripulante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TRIPULANTE_Cruzeiros_ID_CRUZEIRO",
                table: "TRIPULANTE");

            migrationBuilder.DropForeignKey(
                name: "FK_TRIPULANTE_Quartos_ID_QUARTO",
                table: "TRIPULANTE");

            migrationBuilder.DropForeignKey(
                name: "FK_TRIPULANTE_SexoTripulante_ID_SEXO",
                table: "TRIPULANTE");

            migrationBuilder.DropForeignKey(
                name: "FK_TRIPULANTE_TipoTripulante_ID_TIPO_TRIPULANTE",
                table: "TRIPULANTE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TRIPULANTE",
                table: "TRIPULANTE");

            migrationBuilder.RenameTable(
                name: "TRIPULANTE",
                newName: "Tripulantes");

            migrationBuilder.RenameColumn(
                name: "NOME",
                table: "Tripulantes",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "IDADE",
                table: "Tripulantes",
                newName: "Idade");

            migrationBuilder.RenameColumn(
                name: "DOCUMENTO",
                table: "Tripulantes",
                newName: "Documento");

            migrationBuilder.RenameColumn(
                name: "ID_TIPO_TRIPULANTE",
                table: "Tripulantes",
                newName: "TipoTripulanteId");

            migrationBuilder.RenameColumn(
                name: "ID_SEXO",
                table: "Tripulantes",
                newName: "SexoTripulanteId");

            migrationBuilder.RenameColumn(
                name: "ID_QUARTO",
                table: "Tripulantes",
                newName: "QuartoId");

            migrationBuilder.RenameColumn(
                name: "ID_CRUZEIRO",
                table: "Tripulantes",
                newName: "CruzeiroId");

            migrationBuilder.RenameColumn(
                name: "ID_TRIPULANTE",
                table: "Tripulantes",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_TRIPULANTE_ID_TIPO_TRIPULANTE",
                table: "Tripulantes",
                newName: "IX_Tripulantes_TipoTripulanteId");

            migrationBuilder.RenameIndex(
                name: "IX_TRIPULANTE_ID_SEXO",
                table: "Tripulantes",
                newName: "IX_Tripulantes_SexoTripulanteId");

            migrationBuilder.RenameIndex(
                name: "IX_TRIPULANTE_ID_QUARTO",
                table: "Tripulantes",
                newName: "IX_Tripulantes_QuartoId");

            migrationBuilder.RenameIndex(
                name: "IX_TRIPULANTE_ID_CRUZEIRO",
                table: "Tripulantes",
                newName: "IX_Tripulantes_CruzeiroId");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Tripulantes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Documento",
                table: "Tripulantes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "QuartoId",
                table: "Tripulantes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CruzeiroId",
                table: "Tripulantes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tripulantes",
                table: "Tripulantes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tripulantes_Cruzeiros_CruzeiroId",
                table: "Tripulantes",
                column: "CruzeiroId",
                principalTable: "Cruzeiros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tripulantes_Quartos_QuartoId",
                table: "Tripulantes",
                column: "QuartoId",
                principalTable: "Quartos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tripulantes_SexoTripulante_SexoTripulanteId",
                table: "Tripulantes",
                column: "SexoTripulanteId",
                principalTable: "SexoTripulante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tripulantes_TipoTripulante_TipoTripulanteId",
                table: "Tripulantes",
                column: "TipoTripulanteId",
                principalTable: "TipoTripulante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
