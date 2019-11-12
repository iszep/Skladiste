using Microsoft.EntityFrameworkCore.Migrations;

namespace Skladiste.Data.Migrations
{
    public partial class zadnja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ukupno",
                table: "Artikal",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ukupno",
                table: "Artikal");
        }
    }
}
