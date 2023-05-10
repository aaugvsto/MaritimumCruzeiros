using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaritimumCruzeiros.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "CUPOM_ID",
                table: "CUPONS");

            migrationBuilder.RenameColumn(
                name: "IdCupom",
                table: "CUPONS",
                newName: "ID_CUPOM");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CUPONS",
                table: "CUPONS",
                column: "ID_CUPOM");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CUPONS",
                table: "CUPONS");

            migrationBuilder.RenameColumn(
                name: "ID_CUPOM",
                table: "CUPONS",
                newName: "IdCupom");

            migrationBuilder.AddPrimaryKey(
                name: "CUPOM_ID",
                table: "CUPONS",
                column: "IdCupom");
        }
    }
}
