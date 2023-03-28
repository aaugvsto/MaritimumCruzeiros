using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CruzeirosEmporio.Migrations
{
    public partial class MapDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cruzeiros_Navios_NavioId",
                table: "Cruzeiros");

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

            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.DropTable(
                name: "Quartos");

            migrationBuilder.DropTable(
                name: "SexoTripulante");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Navios",
                table: "Navios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cruzeiros",
                table: "Cruzeiros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TRIPULANTE",
                table: "TRIPULANTE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoTripulante",
                table: "TipoTripulante");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Cruzeiros");

            migrationBuilder.DropColumn(
                name: "DOCUMENTO",
                table: "TRIPULANTE");

            migrationBuilder.DropColumn(
                name: "IDADE",
                table: "TRIPULANTE");

            migrationBuilder.DropColumn(
                name: "NOME",
                table: "TRIPULANTE");

            migrationBuilder.RenameTable(
                name: "Navios",
                newName: "NAVIOS");

            migrationBuilder.RenameTable(
                name: "Cruzeiros",
                newName: "CRUZEIROS");

            migrationBuilder.RenameTable(
                name: "TRIPULANTE",
                newName: "TRIPULANTES");

            migrationBuilder.RenameTable(
                name: "TipoTripulante",
                newName: "TIPO_TRIPULATE");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "NAVIOS",
                newName: "NOME");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "NAVIOS",
                newName: "ID_NAVIO");

            migrationBuilder.RenameColumn(
                name: "Capacidade",
                table: "NAVIOS",
                newName: "CAPACIDADE_PESSOAS");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "CRUZEIROS",
                newName: "DESCRICAO");

            migrationBuilder.RenameColumn(
                name: "NavioId",
                table: "CRUZEIROS",
                newName: "ID_NAVIO");

            migrationBuilder.RenameColumn(
                name: "DataPartida",
                table: "CRUZEIROS",
                newName: "DATA_PARTIDA");

            migrationBuilder.RenameColumn(
                name: "DataChegada",
                table: "CRUZEIROS",
                newName: "DATA_CHEGADA");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CRUZEIROS",
                newName: "ID_CRUZEIRO");

            migrationBuilder.RenameIndex(
                name: "IX_Cruzeiros_NavioId",
                table: "CRUZEIROS",
                newName: "IX_CRUZEIROS_ID_NAVIO");

            migrationBuilder.RenameColumn(
                name: "ID_SEXO",
                table: "TRIPULANTES",
                newName: "ID_PESSOA");

            migrationBuilder.RenameIndex(
                name: "IX_TRIPULANTE_ID_TIPO_TRIPULANTE",
                table: "TRIPULANTES",
                newName: "IX_TRIPULANTES_ID_TIPO_TRIPULANTE");

            migrationBuilder.RenameIndex(
                name: "IX_TRIPULANTE_ID_SEXO",
                table: "TRIPULANTES",
                newName: "IX_TRIPULANTES_ID_PESSOA");

            migrationBuilder.RenameIndex(
                name: "IX_TRIPULANTE_ID_QUARTO",
                table: "TRIPULANTES",
                newName: "IX_TRIPULANTES_ID_QUARTO");

            migrationBuilder.RenameIndex(
                name: "IX_TRIPULANTE_ID_CRUZEIRO",
                table: "TRIPULANTES",
                newName: "IX_TRIPULANTES_ID_CRUZEIRO");

            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "TIPO_TRIPULATE",
                newName: "TIPO");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TIPO_TRIPULATE",
                newName: "ID_TIPO_TRIPULANTE");

            migrationBuilder.AlterColumn<string>(
                name: "NOME",
                table: "NAVIOS",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID_NAVIO",
                table: "CRUZEIROS",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NOME_EXPEDICAO",
                table: "CRUZEIROS",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "ID_QUARTO",
                table: "TRIPULANTES",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID_CRUZEIRO",
                table: "TRIPULANTES",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_NAVIOS",
                table: "NAVIOS",
                column: "ID_NAVIO");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CRUZEIROS",
                table: "CRUZEIROS",
                column: "ID_CRUZEIRO");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TRIPULANTES",
                table: "TRIPULANTES",
                column: "ID_TRIPULANTE");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TIPO_TRIPULATE",
                table: "TIPO_TRIPULATE",
                column: "ID_TIPO_TRIPULANTE");

            migrationBuilder.CreateTable(
                name: "SEXO_PESSOA",
                columns: table => new
                {
                    ID_SEXO_PESSOA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SEXO = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SEXO_PESSOA", x => x.ID_SEXO_PESSOA);
                });

            migrationBuilder.CreateTable(
                name: "TIPO_CABINE",
                columns: table => new
                {
                    ID_TIPO_CABINE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TIPO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPO_CABINE", x => x.ID_TIPO_CABINE);
                });

            migrationBuilder.CreateTable(
                name: "PESSOAS",
                columns: table => new
                {
                    ID_PESSOA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IDADE = table.Column<int>(type: "int", nullable: false),
                    ID_SEXO_PESSOA = table.Column<int>(type: "int", nullable: false),
                    DOCUMENTO = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PESSOAS", x => x.ID_PESSOA);
                    table.ForeignKey(
                        name: "FK_PESSOAS_SEXO_PESSOA_ID_SEXO_PESSOA",
                        column: x => x.ID_SEXO_PESSOA,
                        principalTable: "SEXO_PESSOA",
                        principalColumn: "ID_SEXO_PESSOA",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CABINES",
                columns: table => new
                {
                    ID_CABINE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_NAVIO = table.Column<int>(type: "int", nullable: false),
                    NUMERO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PISO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CAPACIDADE_MAXIMA = table.Column<int>(type: "int", nullable: false),
                    ID_TIPO_CABINE = table.Column<int>(type: "int", nullable: false),
                    IndFechado = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CABINES", x => x.ID_CABINE);
                    table.ForeignKey(
                        name: "FK_CABINES_NAVIOS_ID_NAVIO",
                        column: x => x.ID_NAVIO,
                        principalTable: "NAVIOS",
                        principalColumn: "ID_NAVIO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CABINES_TIPO_CABINE_ID_TIPO_CABINE",
                        column: x => x.ID_TIPO_CABINE,
                        principalTable: "TIPO_CABINE",
                        principalColumn: "ID_TIPO_CABINE",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CABINES_ID_NAVIO",
                table: "CABINES",
                column: "ID_NAVIO");

            migrationBuilder.CreateIndex(
                name: "IX_CABINES_ID_TIPO_CABINE",
                table: "CABINES",
                column: "ID_TIPO_CABINE");

            migrationBuilder.CreateIndex(
                name: "IX_PESSOAS_ID_SEXO_PESSOA",
                table: "PESSOAS",
                column: "ID_SEXO_PESSOA");

            migrationBuilder.AddForeignKey(
                name: "FK_CRUZEIROS_NAVIOS_ID_NAVIO",
                table: "CRUZEIROS",
                column: "ID_NAVIO",
                principalTable: "NAVIOS",
                principalColumn: "ID_NAVIO",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TRIPULANTES_CABINES_ID_QUARTO",
                table: "TRIPULANTES",
                column: "ID_QUARTO",
                principalTable: "CABINES",
                principalColumn: "ID_CABINE",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TRIPULANTES_CRUZEIROS_ID_CRUZEIRO",
                table: "TRIPULANTES",
                column: "ID_CRUZEIRO",
                principalTable: "CRUZEIROS",
                principalColumn: "ID_CRUZEIRO",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TRIPULANTES_PESSOAS_ID_PESSOA",
                table: "TRIPULANTES",
                column: "ID_PESSOA",
                principalTable: "PESSOAS",
                principalColumn: "ID_PESSOA",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TRIPULANTES_TIPO_TRIPULATE_ID_TIPO_TRIPULANTE",
                table: "TRIPULANTES",
                column: "ID_TIPO_TRIPULANTE",
                principalTable: "TIPO_TRIPULATE",
                principalColumn: "ID_TIPO_TRIPULANTE",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CRUZEIROS_NAVIOS_ID_NAVIO",
                table: "CRUZEIROS");

            migrationBuilder.DropForeignKey(
                name: "FK_TRIPULANTES_CABINES_ID_QUARTO",
                table: "TRIPULANTES");

            migrationBuilder.DropForeignKey(
                name: "FK_TRIPULANTES_CRUZEIROS_ID_CRUZEIRO",
                table: "TRIPULANTES");

            migrationBuilder.DropForeignKey(
                name: "FK_TRIPULANTES_PESSOAS_ID_PESSOA",
                table: "TRIPULANTES");

            migrationBuilder.DropForeignKey(
                name: "FK_TRIPULANTES_TIPO_TRIPULATE_ID_TIPO_TRIPULANTE",
                table: "TRIPULANTES");

            migrationBuilder.DropTable(
                name: "CABINES");

            migrationBuilder.DropTable(
                name: "PESSOAS");

            migrationBuilder.DropTable(
                name: "TIPO_CABINE");

            migrationBuilder.DropTable(
                name: "SEXO_PESSOA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NAVIOS",
                table: "NAVIOS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CRUZEIROS",
                table: "CRUZEIROS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TRIPULANTES",
                table: "TRIPULANTES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TIPO_TRIPULATE",
                table: "TIPO_TRIPULATE");

            migrationBuilder.DropColumn(
                name: "NOME_EXPEDICAO",
                table: "CRUZEIROS");

            migrationBuilder.RenameTable(
                name: "NAVIOS",
                newName: "Navios");

            migrationBuilder.RenameTable(
                name: "CRUZEIROS",
                newName: "Cruzeiros");

            migrationBuilder.RenameTable(
                name: "TRIPULANTES",
                newName: "TRIPULANTE");

            migrationBuilder.RenameTable(
                name: "TIPO_TRIPULATE",
                newName: "TipoTripulante");

            migrationBuilder.RenameColumn(
                name: "NOME",
                table: "Navios",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "ID_NAVIO",
                table: "Navios",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CAPACIDADE_PESSOAS",
                table: "Navios",
                newName: "Capacidade");

            migrationBuilder.RenameColumn(
                name: "DESCRICAO",
                table: "Cruzeiros",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "ID_NAVIO",
                table: "Cruzeiros",
                newName: "NavioId");

            migrationBuilder.RenameColumn(
                name: "DATA_PARTIDA",
                table: "Cruzeiros",
                newName: "DataPartida");

            migrationBuilder.RenameColumn(
                name: "DATA_CHEGADA",
                table: "Cruzeiros",
                newName: "DataChegada");

            migrationBuilder.RenameColumn(
                name: "ID_CRUZEIRO",
                table: "Cruzeiros",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_CRUZEIROS_ID_NAVIO",
                table: "Cruzeiros",
                newName: "IX_Cruzeiros_NavioId");

            migrationBuilder.RenameColumn(
                name: "ID_PESSOA",
                table: "TRIPULANTE",
                newName: "ID_SEXO");

            migrationBuilder.RenameIndex(
                name: "IX_TRIPULANTES_ID_TIPO_TRIPULANTE",
                table: "TRIPULANTE",
                newName: "IX_TRIPULANTE_ID_TIPO_TRIPULANTE");

            migrationBuilder.RenameIndex(
                name: "IX_TRIPULANTES_ID_QUARTO",
                table: "TRIPULANTE",
                newName: "IX_TRIPULANTE_ID_QUARTO");

            migrationBuilder.RenameIndex(
                name: "IX_TRIPULANTES_ID_PESSOA",
                table: "TRIPULANTE",
                newName: "IX_TRIPULANTE_ID_SEXO");

            migrationBuilder.RenameIndex(
                name: "IX_TRIPULANTES_ID_CRUZEIRO",
                table: "TRIPULANTE",
                newName: "IX_TRIPULANTE_ID_CRUZEIRO");

            migrationBuilder.RenameColumn(
                name: "TIPO",
                table: "TipoTripulante",
                newName: "Tipo");

            migrationBuilder.RenameColumn(
                name: "ID_TIPO_TRIPULANTE",
                table: "TipoTripulante",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Navios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NavioId",
                table: "Cruzeiros",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Cruzeiros",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.AddColumn<string>(
                name: "DOCUMENTO",
                table: "TRIPULANTE",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IDADE",
                table: "TRIPULANTE",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NOME",
                table: "TRIPULANTE",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Navios",
                table: "Navios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cruzeiros",
                table: "Cruzeiros",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TRIPULANTE",
                table: "TRIPULANTE",
                column: "ID_TRIPULANTE");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoTripulante",
                table: "TipoTripulante",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CruzeiroId = table.Column<int>(type: "int", nullable: true),
                    DataHoraEvento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Eventos_Cruzeiros_CruzeiroId",
                        column: x => x.CruzeiroId,
                        principalTable: "Cruzeiros",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Quartos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NavioId = table.Column<int>(type: "int", nullable: true),
                    Capacidade = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndFechado = table.Column<bool>(type: "bit", nullable: true),
                    Piso = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quartos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quartos_Navios_NavioId",
                        column: x => x.NavioId,
                        principalTable: "Navios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SexoTripulante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SexoTripulante", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_CruzeiroId",
                table: "Eventos",
                column: "CruzeiroId");

            migrationBuilder.CreateIndex(
                name: "IX_Quartos_NavioId",
                table: "Quartos",
                column: "NavioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cruzeiros_Navios_NavioId",
                table: "Cruzeiros",
                column: "NavioId",
                principalTable: "Navios",
                principalColumn: "Id");

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
    }
}
