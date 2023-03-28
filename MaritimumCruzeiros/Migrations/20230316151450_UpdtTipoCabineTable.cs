using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CruzeirosEmporio.Migrations
{
    public partial class UpdtTipoCabineTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TIPO",
                table: "TIPO_CABINE",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "DESCRICAO",
                table: "TIPO_CABINE",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DESCRICAO",
                table: "TIPO_CABINE");

            migrationBuilder.AlterColumn<int>(
                name: "TIPO",
                table: "TIPO_CABINE",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
