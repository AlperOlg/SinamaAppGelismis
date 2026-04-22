using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinamaApp.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Biletler_Kullanicilar_KullaniciID",
                table: "Biletler");

            migrationBuilder.DropForeignKey(
                name: "FK_Biletler_Seanslar_SeansID",
                table: "Biletler");

            migrationBuilder.AddForeignKey(
                name: "FK_Biletler_Kullanicilar_KullaniciID",
                table: "Biletler",
                column: "KullaniciID",
                principalTable: "Kullanicilar",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Biletler_Seanslar_SeansID",
                table: "Biletler",
                column: "SeansID",
                principalTable: "Seanslar",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Biletler_Kullanicilar_KullaniciID",
                table: "Biletler");

            migrationBuilder.DropForeignKey(
                name: "FK_Biletler_Seanslar_SeansID",
                table: "Biletler");

            migrationBuilder.AddForeignKey(
                name: "FK_Biletler_Kullanicilar_KullaniciID",
                table: "Biletler",
                column: "KullaniciID",
                principalTable: "Kullanicilar",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Biletler_Seanslar_SeansID",
                table: "Biletler",
                column: "SeansID",
                principalTable: "Seanslar",
                principalColumn: "ID");
        }
    }
}
