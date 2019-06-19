using Microsoft.EntityFrameworkCore.Migrations;

namespace ETicaret.Migrations
{
    public partial class Ticaretti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Baslik",
                table: "Yorums",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Baslik",
                table: "Yorums");
        }
    }
}
