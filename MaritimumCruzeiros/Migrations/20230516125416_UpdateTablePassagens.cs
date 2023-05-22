using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaritimumCruzeiros.Migrations
{
    public partial class UpdateTablePassagens : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TitularCPF",
                table: "PASSAGENS",
                newName: "CPF_TITULAR_PASSAGEM");

            migrationBuilder.RenameColumn(
                name: "NumeroPassaporte",
                table: "PASSAGENS",
                newName: "PASSAPORTE_TITULAR_PASSAGEM");

            migrationBuilder.AlterColumn<string>(
                name: "NOME_TITULAR_PASSAGEN",
                table: "PASSAGENS",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "EMAIL_PESSOA_TITULAR",
                table: "PASSAGENS",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PASSAPORTE_TITULAR_PASSAGEM",
                table: "PASSAGENS",
                newName: "NumeroPassaporte");

            migrationBuilder.RenameColumn(
                name: "CPF_TITULAR_PASSAGEM",
                table: "PASSAGENS",
                newName: "TitularCPF");

            migrationBuilder.UpdateData(
                table: "PASSAGENS",
                keyColumn: "NOME_TITULAR_PASSAGEN",
                keyValue: null,
                column: "NOME_TITULAR_PASSAGEN",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "NOME_TITULAR_PASSAGEN",
                table: "PASSAGENS",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "PASSAGENS",
                keyColumn: "EMAIL_PESSOA_TITULAR",
                keyValue: null,
                column: "EMAIL_PESSOA_TITULAR",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "EMAIL_PESSOA_TITULAR",
                table: "PASSAGENS",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
