using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ETicaret.Migrations
{
    public partial class Kategori : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MagazaTur",
                table: "Magazas");

            migrationBuilder.AddColumn<int>(
                name: "MagazaTurID",
                table: "Magazas",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Kategoris",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tur = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoris", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Magazas_MagazaTurID",
                table: "Magazas",
                column: "MagazaTurID");

            migrationBuilder.AddForeignKey(
                name: "FK_Magazas_Kategoris_MagazaTurID",
                table: "Magazas",
                column: "MagazaTurID",
                principalTable: "Kategoris",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Magazas_Kategoris_MagazaTurID",
                table: "Magazas");

            migrationBuilder.DropTable(
                name: "Kategoris");

            migrationBuilder.DropIndex(
                name: "IX_Magazas_MagazaTurID",
                table: "Magazas");

            migrationBuilder.DropColumn(
                name: "MagazaTurID",
                table: "Magazas");

            migrationBuilder.AddColumn<int>(
                name: "MagazaTur",
                table: "Magazas",
                nullable: false,
                defaultValue: 0);
        }
    }
}
