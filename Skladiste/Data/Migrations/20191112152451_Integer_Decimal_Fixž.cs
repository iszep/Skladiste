using Microsoft.EntityFrameworkCore.Migrations;

namespace Skladiste.Data.Migrations
{
    public partial class Integer_Decimal_Fixž : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ukupno",
                table: "Artikal");

            migrationBuilder.AlterColumn<decimal>(
                name: "Kolicina",
                table: "Artikal",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Kolicina",
                table: "Artikal",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AddColumn<int>(
                name: "Ukupno",
                table: "Artikal",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
