using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ETicaret.Migrations
{
    public partial class yeninn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Magazas",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MagazaKullanici",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MagazaAdi = table.Column<string>(nullable: false),
                    KullaciAdi = table.Column<string>(nullable: false),
                    MagazaTur = table.Column<int>(nullable: false),
                    MagazaMail = table.Column<string>(nullable: false),
                    MagazaTel = table.Column<string>(nullable: false),
                    MagazaTanitim = table.Column<string>(nullable: false),
                    FotoGenel = table.Column<string>(nullable: false),
                    FotoGenel2 = table.Column<string>(nullable: false),
                    Kapasite = table.Column<int>(nullable: false),
                    MagazaAdres = table.Column<string>(nullable: false),
                    AcikAlan = table.Column<bool>(nullable: false),
                    Wifi = table.Column<bool>(nullable: false),
                    Otopark = table.Column<bool>(nullable: false),
                    Alkol = table.Column<bool>(nullable: false),
                    MacYayini = table.Column<bool>(nullable: false),
                    Oyun = table.Column<bool>(nullable: false),
                    Kart = table.Column<bool>(nullable: false),
                    Parola = table.Column<string>(nullable: false),
                    IlID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagazaKullanici", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MagazaKullanici");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Magazas");
        }
    }
}
