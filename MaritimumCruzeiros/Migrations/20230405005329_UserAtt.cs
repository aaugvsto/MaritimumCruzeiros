using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaritimumCruzeiros.Migrations
{
    public partial class UserAtt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EMAIL",
                table: "PESSOAS",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "SENHA",
                table: "PESSOAS",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EMAIL",
                table: "PESSOAS");

            migrationBuilder.DropColumn(
                name: "SENHA",
                table: "PESSOAS");
        }
    }
}
