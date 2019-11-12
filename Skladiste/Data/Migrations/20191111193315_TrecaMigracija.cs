using Microsoft.EntityFrameworkCore.Migrations;

namespace Skladiste.Data.Migrations
{
    public partial class TrecaMigracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Jedinica_Mjere",
                table: "Artikal",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Jedinica_Mjere",
                table: "Artikal");
        }
    }
}
