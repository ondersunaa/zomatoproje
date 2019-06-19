using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ETicaret.Migrations
{
    public partial class TTT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AcikAlan",
                table: "Magazas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Alkol",
                table: "Magazas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MacYayini",
                table: "Magazas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MagazaAdres",
                table: "Magazas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Otopark",
                table: "Magazas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Oyun",
                table: "Magazas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Wifi",
                table: "Magazas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Yorumculars",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Isim = table.Column<string>(nullable: true),
                    Soyisim = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Sifre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorumculars", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Yorumculars");

            migrationBuilder.DropColumn(
                name: "AcikAlan",
                table: "Magazas");

            migrationBuilder.DropColumn(
                name: "Alkol",
                table: "Magazas");

            migrationBuilder.DropColumn(
                name: "MacYayini",
                table: "Magazas");

            migrationBuilder.DropColumn(
                name: "MagazaAdres",
                table: "Magazas");

            migrationBuilder.DropColumn(
                name: "Otopark",
                table: "Magazas");

            migrationBuilder.DropColumn(
                name: "Oyun",
                table: "Magazas");

            migrationBuilder.DropColumn(
                name: "Wifi",
                table: "Magazas");
        }
    }
}
