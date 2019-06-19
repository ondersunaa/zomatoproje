using Microsoft.EntityFrameworkCore.Migrations;

namespace ETicaret.Migrations.ApplicationIdentityDb
{
    public partial class bilinmelikler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AcikAlan",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Alkol",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "FavoriFoto",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FotoGenel",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FotoGenel2",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IlID",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IlceID",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Kapasite",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Kart",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "MacYayini",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "MagazaAdres",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MagazaTanitim",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MagazaTur",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Otopark",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Oyun",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Wifi",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcikAlan",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Alkol",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FavoriFoto",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FotoGenel",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FotoGenel2",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IlID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IlceID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Kapasite",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Kart",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MacYayini",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MagazaAdres",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MagazaTanitim",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MagazaTur",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Otopark",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Oyun",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Wifi",
                table: "AspNetUsers");
        }
    }
}
