using Microsoft.EntityFrameworkCore.Migrations;

namespace Deneme4.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "STGraphicscard",
                table: "students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "STMainboard",
                table: "students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "STMonitor",
                table: "students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "STRam",
                table: "students",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "STGraphicscard",
                table: "students");

            migrationBuilder.DropColumn(
                name: "STMainboard",
                table: "students");

            migrationBuilder.DropColumn(
                name: "STMonitor",
                table: "students");

            migrationBuilder.DropColumn(
                name: "STRam",
                table: "students");
        }
    }
}
