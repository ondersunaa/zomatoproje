using Microsoft.EntityFrameworkCore.Migrations;

namespace ETicaret.Migrations
{
    public partial class sanane : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Magazas_Kategoris_MagazaTurID",
                table: "Magazas");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MagazaTur",
                table: "Magazas");

            migrationBuilder.AddColumn<int>(
                name: "MagazaTurID",
                table: "Magazas",
                nullable: true);

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
    }
}
