using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinamaApp.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Oyuncular",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oyuncular", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Salonlar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalonNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salonlar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Yonetmenler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yonetmenler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Filmler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmAd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FilmYili = table.Column<int>(type: "int", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false),
                    YonetmenID = table.Column<int>(type: "int", nullable: false),
                    BasRolOyuncuID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Filmler_Kategoriler_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategoriler",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Filmler_Oyuncular_BasRolOyuncuID",
                        column: x => x.BasRolOyuncuID,
                        principalTable: "Oyuncular",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Filmler_Yonetmenler_YonetmenID",
                        column: x => x.YonetmenID,
                        principalTable: "Yonetmenler",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FilmOyuncu",
                columns: table => new
                {
                    FilmlerID = table.Column<int>(type: "int", nullable: false),
                    OyuncularID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmOyuncu", x => new { x.FilmlerID, x.OyuncularID });
                    table.ForeignKey(
                        name: "FK_FilmOyuncu_Filmler_FilmlerID",
                        column: x => x.FilmlerID,
                        principalTable: "Filmler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmOyuncu_Oyuncular_OyuncularID",
                        column: x => x.OyuncularID,
                        principalTable: "Oyuncular",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seanslar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeansSaati = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FilmID = table.Column<int>(type: "int", nullable: false),
                    SalonID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seanslar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Seanslar_Filmler_FilmID",
                        column: x => x.FilmID,
                        principalTable: "Filmler",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Seanslar_Salonlar_SalonID",
                        column: x => x.SalonID,
                        principalTable: "Salonlar",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Biletler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciID = table.Column<int>(type: "int", nullable: false),
                    SeansID = table.Column<int>(type: "int", nullable: false),
                    KoltukNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biletler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Biletler_Kullanicilar_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanicilar",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Biletler_Seanslar_SeansID",
                        column: x => x.SeansID,
                        principalTable: "Seanslar",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Biletler_KullaniciID",
                table: "Biletler",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_Biletler_SeansID_KoltukNo",
                table: "Biletler",
                columns: new[] { "SeansID", "KoltukNo" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Filmler_BasRolOyuncuID",
                table: "Filmler",
                column: "BasRolOyuncuID");

            migrationBuilder.CreateIndex(
                name: "IX_Filmler_KategoriID",
                table: "Filmler",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_Filmler_YonetmenID",
                table: "Filmler",
                column: "YonetmenID");

            migrationBuilder.CreateIndex(
                name: "IX_FilmOyuncu_OyuncularID",
                table: "FilmOyuncu",
                column: "OyuncularID");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_KullaniciAdi",
                table: "Kullanicilar",
                column: "KullaniciAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Salonlar_SalonNo",
                table: "Salonlar",
                column: "SalonNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seanslar_FilmID",
                table: "Seanslar",
                column: "FilmID");

            migrationBuilder.CreateIndex(
                name: "IX_Seanslar_SalonID",
                table: "Seanslar",
                column: "SalonID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Biletler");

            migrationBuilder.DropTable(
                name: "FilmOyuncu");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "Seanslar");

            migrationBuilder.DropTable(
                name: "Filmler");

            migrationBuilder.DropTable(
                name: "Salonlar");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropTable(
                name: "Oyuncular");

            migrationBuilder.DropTable(
                name: "Yonetmenler");
        }
    }
}
