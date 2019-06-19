using Microsoft.EntityFrameworkCore.Migrations;

namespace ETicaret.Migrations.ApplicationIdentityDb
{
    public partial class magazalarrr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MagazaAdi",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MagazaAdi",
                table: "AspNetUsers");
        }
    }
}
