using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinamaApp.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Biletler_SeansID_KoltukNo",
                table: "Biletler");

            migrationBuilder.DropColumn(
                name: "KoltukNo",
                table: "Biletler");

            migrationBuilder.AddColumn<int>(
                name: "BiletDurumu",
                table: "Biletler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KoltukID",
                table: "Biletler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "SatinAlmaTarihi",
                table: "Biletler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Koltuk",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numara = table.Column<int>(type: "int", nullable: false),
                    Satir = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SalonID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Koltuk", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Koltuk_Salonlar_SalonID",
                        column: x => x.SalonID,
                        principalTable: "Salonlar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Biletler_KoltukID",
                table: "Biletler",
                column: "KoltukID");

            migrationBuilder.CreateIndex(
                name: "IX_Biletler_SeansID_KoltukID",
                table: "Biletler",
                columns: new[] { "SeansID", "KoltukID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Koltuk_Numara_Satir_SalonID",
                table: "Koltuk",
                columns: new[] { "Numara", "Satir", "SalonID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Koltuk_SalonID",
                table: "Koltuk",
                column: "SalonID");

            migrationBuilder.AddForeignKey(
                name: "FK_Biletler_Koltuk_KoltukID",
                table: "Biletler",
                column: "KoltukID",
                principalTable: "Koltuk",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Biletler_Koltuk_KoltukID",
                table: "Biletler");

            migrationBuilder.DropTable(
                name: "Koltuk");

            migrationBuilder.DropIndex(
                name: "IX_Biletler_KoltukID",
                table: "Biletler");

            migrationBuilder.DropIndex(
                name: "IX_Biletler_SeansID_KoltukID",
                table: "Biletler");

            migrationBuilder.DropColumn(
                name: "BiletDurumu",
                table: "Biletler");

            migrationBuilder.DropColumn(
                name: "KoltukID",
                table: "Biletler");

            migrationBuilder.DropColumn(
                name: "SatinAlmaTarihi",
                table: "Biletler");

            migrationBuilder.AddColumn<string>(
                name: "KoltukNo",
                table: "Biletler",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Biletler_SeansID_KoltukNo",
                table: "Biletler",
                columns: new[] { "SeansID", "KoltukNo" },
                unique: true);
        }
    }
}
