using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FestivalService.Migrations
{
    public partial class AddOrderToFestivals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FestivalOrder",
                table: "Festivals",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FestivalOrder",
                table: "Festivals");
        }
    }
}
