using Microsoft.EntityFrameworkCore.Migrations;

namespace ETicaret.Migrations
{
    public partial class Ticarettdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MenuId",
                table: "Magazas",
                newName: "MagazaTur");

            migrationBuilder.RenameColumn(
                name: "Magazailce",
                table: "Magazas",
                newName: "MagazaTel");

            migrationBuilder.RenameColumn(
                name: "Magazail",
                table: "Magazas",
                newName: "MagazaTanitim");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Magazas",
                newName: "MagazaId");

            migrationBuilder.AddColumn<string>(
                name: "FavoriFoto",
                table: "Magazas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FavoriID",
                table: "Magazas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FotoGenel",
                table: "Magazas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FotoGenel2",
                table: "Magazas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IlID",
                table: "Magazas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IlceID",
                table: "Magazas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Kapasite",
                table: "Magazas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MagazaMail",
                table: "Magazas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FavoriFoto",
                table: "Magazas");

            migrationBuilder.DropColumn(
                name: "FavoriID",
                table: "Magazas");

            migrationBuilder.DropColumn(
                name: "FotoGenel",
                table: "Magazas");

            migrationBuilder.DropColumn(
                name: "FotoGenel2",
                table: "Magazas");

            migrationBuilder.DropColumn(
                name: "IlID",
                table: "Magazas");

            migrationBuilder.DropColumn(
                name: "IlceID",
                table: "Magazas");

            migrationBuilder.DropColumn(
                name: "Kapasite",
                table: "Magazas");

            migrationBuilder.DropColumn(
                name: "MagazaMail",
                table: "Magazas");

            migrationBuilder.RenameColumn(
                name: "MagazaTur",
                table: "Magazas",
                newName: "MenuId");

            migrationBuilder.RenameColumn(
                name: "MagazaTel",
                table: "Magazas",
                newName: "Magazailce");

            migrationBuilder.RenameColumn(
                name: "MagazaTanitim",
                table: "Magazas",
                newName: "Magazail");

            migrationBuilder.RenameColumn(
                name: "MagazaId",
                table: "Magazas",
                newName: "ID");
        }
    }
}
