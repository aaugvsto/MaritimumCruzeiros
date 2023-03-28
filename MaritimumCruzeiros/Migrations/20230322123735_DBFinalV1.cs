using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CruzeirosEmporio.Migrations
{
    public partial class DBFinalV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IndFechado",
                table: "CABINES");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IndFechado",
                table: "CABINES",
                type: "bit",
                nullable: true,
                defaultValue: false);
        }
    }
}
