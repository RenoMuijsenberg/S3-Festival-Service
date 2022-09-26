using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FestivalService.Migrations
{
    public partial class FirstCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Festivals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FestivalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FestivalPrice = table.Column<double>(type: "float", nullable: false),
                    FestivalTimeFrame = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FestivalDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Festivals", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Festivals");
        }
    }
}
