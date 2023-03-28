using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CruzeirosEmporio.Migrations
{
    public partial class InitalBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Navios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Navios", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "TipoTripulante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTripulante", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cruzeiros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataPartida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataChegada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NavioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cruzeiros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cruzeiros_Navios_NavioId",
                        column: x => x.NavioId,
                        principalTable: "Navios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Quartos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Piso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacidade = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NavioId = table.Column<int>(type: "int", nullable: true),
                    IndFechado = table.Column<bool>(type: "bit", nullable: true)
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
                name: "Eventos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataHoraEvento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CruzeiroId = table.Column<int>(type: "int", nullable: true)
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
                name: "TRIPULANTE",
                columns: table => new
                {
                    ID_TRIPULANTE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IDADE = table.Column<int>(type: "int", nullable: false),
                    ID_SEXO = table.Column<int>(type: "int", nullable: false),
                    ID_TIPO_TRIPULANTE = table.Column<int>(type: "int", nullable: false),
                    DOCUMENTO = table.Column<int>(type: "int", nullable: false),
                    ID_QUARTO = table.Column<int>(type: "int", nullable: false),
                    CruzeiroId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRIPULANTE", x => x.ID_TRIPULANTE);
                    table.ForeignKey(
                        name: "FK_TRIPULANTE_Cruzeiros_CruzeiroId",
                        column: x => x.CruzeiroId,
                        principalTable: "Cruzeiros",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TRIPULANTE_Quartos_ID_QUARTO",
                        column: x => x.ID_QUARTO,
                        principalTable: "Quartos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TRIPULANTE_SexoTripulante_ID_SEXO",
                        column: x => x.ID_SEXO,
                        principalTable: "SexoTripulante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TRIPULANTE_TipoTripulante_ID_TIPO_TRIPULANTE",
                        column: x => x.ID_TIPO_TRIPULANTE,
                        principalTable: "TipoTripulante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cruzeiros_NavioId",
                table: "Cruzeiros",
                column: "NavioId");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_CruzeiroId",
                table: "Eventos",
                column: "CruzeiroId");

            migrationBuilder.CreateIndex(
                name: "IX_Quartos_NavioId",
                table: "Quartos",
                column: "NavioId");

            migrationBuilder.CreateIndex(
                name: "IX_TRIPULANTE_CruzeiroId",
                table: "TRIPULANTE",
                column: "CruzeiroId");

            migrationBuilder.CreateIndex(
                name: "IX_TRIPULANTE_ID_QUARTO",
                table: "TRIPULANTE",
                column: "ID_QUARTO");

            migrationBuilder.CreateIndex(
                name: "IX_TRIPULANTE_ID_SEXO",
                table: "TRIPULANTE",
                column: "ID_SEXO");

            migrationBuilder.CreateIndex(
                name: "IX_TRIPULANTE_ID_TIPO_TRIPULANTE",
                table: "TRIPULANTE",
                column: "ID_TIPO_TRIPULANTE");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.DropTable(
                name: "TRIPULANTE");

            migrationBuilder.DropTable(
                name: "Cruzeiros");

            migrationBuilder.DropTable(
                name: "Quartos");

            migrationBuilder.DropTable(
                name: "SexoTripulante");

            migrationBuilder.DropTable(
                name: "TipoTripulante");

            migrationBuilder.DropTable(
                name: "Navios");
        }
    }
}
