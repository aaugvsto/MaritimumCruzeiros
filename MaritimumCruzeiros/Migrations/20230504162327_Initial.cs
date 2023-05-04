using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaritimumCruzeiros.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "NAVIOS",
                columns: table => new
                {
                    ID_NAVIO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NOME = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CAPACIDADE_PESSOAS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NAVIOS", x => x.ID_NAVIO);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SEXO_PESSOA",
                columns: table => new
                {
                    ID_SEXO_PESSOA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SEXO = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SEXO_PESSOA", x => x.ID_SEXO_PESSOA);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TIPO_CABINE",
                columns: table => new
                {
                    ID_TIPO_CABINE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TIPO = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DESCRICAO = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPO_CABINE", x => x.ID_TIPO_CABINE);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TIPO_TRIPULATE",
                columns: table => new
                {
                    ID_TIPO_TRIPULANTE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TIPO = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPO_TRIPULATE", x => x.ID_TIPO_TRIPULANTE);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CRUZEIROS",
                columns: table => new
                {
                    ID_CRUZEIRO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NOME_EXPEDICAO = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DATA_PARTIDA = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DATA_CHEGADA = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DESCRICAO = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ID_NAVIO = table.Column<int>(type: "int", nullable: false),
                    PRECO = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CRUZEIROS", x => x.ID_CRUZEIRO);
                    table.ForeignKey(
                        name: "FK_CRUZEIROS_NAVIOS_ID_NAVIO",
                        column: x => x.ID_NAVIO,
                        principalTable: "NAVIOS",
                        principalColumn: "ID_NAVIO",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PESSOAS",
                columns: table => new
                {
                    ID_PESSOA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NOME = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EMAIL = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IDADE = table.Column<int>(type: "int", nullable: false),
                    ID_SEXO_PESSOA = table.Column<int>(type: "int", nullable: false),
                    DOCUMENTO = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SENHA = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CABINES",
                columns: table => new
                {
                    ID_CABINE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ID_NAVIO = table.Column<int>(type: "int", nullable: false),
                    NUMERO = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PISO = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CAPACIDADE_MAXIMA = table.Column<int>(type: "int", nullable: false),
                    ID_TIPO_CABINE = table.Column<int>(type: "int", nullable: false)
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PESSOA_FAVORITOS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ID_PESSOA = table.Column<int>(type: "int", nullable: false),
                    ID_CRUZEIRO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PESSOA_FAVORITOS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PESSOA_FAVORITOS_CRUZEIROS_ID_CRUZEIRO",
                        column: x => x.ID_CRUZEIRO,
                        principalTable: "CRUZEIROS",
                        principalColumn: "ID_CRUZEIRO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PESSOA_FAVORITOS_PESSOAS_ID_PESSOA",
                        column: x => x.ID_PESSOA,
                        principalTable: "PESSOAS",
                        principalColumn: "ID_PESSOA",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CABINE_TRIPULANTE",
                columns: table => new
                {
                    ID_CABINE_TRIPULANTE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TRIPULANTES",
                columns: table => new
                {
                    ID_TRIPULANTE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ID_PESSOA = table.Column<int>(type: "int", nullable: false),
                    ID_TIPO_TRIPULANTE = table.Column<int>(type: "int", nullable: false),
                    ID_CRUZEIRO = table.Column<int>(type: "int", nullable: false),
                    ID_CABINE_TRIPULANTE = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRIPULANTES", x => x.ID_TRIPULANTE);
                    table.ForeignKey(
                        name: "FK_TRIPULANTES_CABINE_TRIPULANTE_ID_CABINE_TRIPULANTE",
                        column: x => x.ID_CABINE_TRIPULANTE,
                        principalTable: "CABINE_TRIPULANTE",
                        principalColumn: "ID_CABINE_TRIPULANTE");
                    table.ForeignKey(
                        name: "FK_TRIPULANTES_CRUZEIROS_ID_CRUZEIRO",
                        column: x => x.ID_CRUZEIRO,
                        principalTable: "CRUZEIROS",
                        principalColumn: "ID_CRUZEIRO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TRIPULANTES_PESSOAS_ID_PESSOA",
                        column: x => x.ID_PESSOA,
                        principalTable: "PESSOAS",
                        principalColumn: "ID_PESSOA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TRIPULANTES_TIPO_TRIPULATE_ID_TIPO_TRIPULANTE",
                        column: x => x.ID_TIPO_TRIPULANTE,
                        principalTable: "TIPO_TRIPULATE",
                        principalColumn: "ID_TIPO_TRIPULANTE",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.CreateIndex(
                name: "IX_CABINES_ID_NAVIO",
                table: "CABINES",
                column: "ID_NAVIO");

            migrationBuilder.CreateIndex(
                name: "IX_CABINES_ID_TIPO_CABINE",
                table: "CABINES",
                column: "ID_TIPO_CABINE");

            migrationBuilder.CreateIndex(
                name: "IX_CRUZEIROS_ID_NAVIO",
                table: "CRUZEIROS",
                column: "ID_NAVIO");

            migrationBuilder.CreateIndex(
                name: "IX_PESSOA_FAVORITOS_ID_CRUZEIRO",
                table: "PESSOA_FAVORITOS",
                column: "ID_CRUZEIRO");

            migrationBuilder.CreateIndex(
                name: "IX_PESSOA_FAVORITOS_ID_PESSOA",
                table: "PESSOA_FAVORITOS",
                column: "ID_PESSOA");

            migrationBuilder.CreateIndex(
                name: "IX_PESSOAS_ID_SEXO_PESSOA",
                table: "PESSOAS",
                column: "ID_SEXO_PESSOA");

            migrationBuilder.CreateIndex(
                name: "IX_TRIPULANTES_ID_CABINE_TRIPULANTE",
                table: "TRIPULANTES",
                column: "ID_CABINE_TRIPULANTE");

            migrationBuilder.CreateIndex(
                name: "IX_TRIPULANTES_ID_CRUZEIRO",
                table: "TRIPULANTES",
                column: "ID_CRUZEIRO");

            migrationBuilder.CreateIndex(
                name: "IX_TRIPULANTES_ID_PESSOA",
                table: "TRIPULANTES",
                column: "ID_PESSOA");

            migrationBuilder.CreateIndex(
                name: "IX_TRIPULANTES_ID_TIPO_TRIPULANTE",
                table: "TRIPULANTES",
                column: "ID_TIPO_TRIPULANTE");

            migrationBuilder.AddForeignKey(
                name: "FK_CABINE_TRIPULANTE_TRIPULANTES_ID_TRIPULANTE",
                table: "CABINE_TRIPULANTE",
                column: "ID_TRIPULANTE",
                principalTable: "TRIPULANTES",
                principalColumn: "ID_TRIPULANTE",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CABINE_TRIPULANTE_CABINES_ID_CABINE",
                table: "CABINE_TRIPULANTE");

            migrationBuilder.DropForeignKey(
                name: "FK_CABINE_TRIPULANTE_TRIPULANTES_ID_TRIPULANTE",
                table: "CABINE_TRIPULANTE");

            migrationBuilder.DropTable(
                name: "PESSOA_FAVORITOS");

            migrationBuilder.DropTable(
                name: "CABINES");

            migrationBuilder.DropTable(
                name: "TIPO_CABINE");

            migrationBuilder.DropTable(
                name: "TRIPULANTES");

            migrationBuilder.DropTable(
                name: "CABINE_TRIPULANTE");

            migrationBuilder.DropTable(
                name: "PESSOAS");

            migrationBuilder.DropTable(
                name: "TIPO_TRIPULATE");

            migrationBuilder.DropTable(
                name: "CRUZEIROS");

            migrationBuilder.DropTable(
                name: "SEXO_PESSOA");

            migrationBuilder.DropTable(
                name: "NAVIOS");
        }
    }
}
