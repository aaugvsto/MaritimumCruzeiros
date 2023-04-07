using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaritimumCruzeiros.Migrations
{
    public partial class AddPrecoCruzeiro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "PRECO",
                table: "CRUZEIROS",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PRECO",
                table: "CRUZEIROS");
        }
    }
}
