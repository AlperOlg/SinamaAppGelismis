using Microsoft.EntityFrameworkCore;
using SinamaApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration;

namespace SinamaApp.DataAccessLayer.Concrete.EFCore
{
    public class SinamaAppDbContext : DbContext
    {
        public SinamaAppDbContext()
        {
        }

        public SinamaAppDbContext(DbContextOptions<SinamaAppDbContext> options) : base(options)
        {
        }
        public DbSet<Film> Filmler { get; set; }
        public DbSet<Yonetmen> Yonetmenler { get; set; }
        public DbSet<Oyuncu> Oyuncular { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Bilet> Biletler { get; set; }
        public DbSet<Salon> Salonlar { get; set; }
        public DbSet<Seans> Seanslar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configurationRoot = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(configurationRoot.GetConnectionString("DefaultConnection"));
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Film
            modelBuilder.Entity<Film>().HasKey(f => f.ID);
            modelBuilder.Entity<Film>().Property(f => f.FilmAd).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Film>().HasOne(f => f.Kategori).WithMany(k => k.Filmler).HasForeignKey(f => f.KategoriID).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Film>().HasOne(f => f.Yonetmen).WithMany(y => y.Filmler).HasForeignKey(f => f.YonetmenID).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Film>().HasMany(f => f.Oyuncular).WithMany(o => o.Filmler);
            modelBuilder.Entity<Film>().HasOne(f => f.BasRolOyuncu).WithMany().HasForeignKey(f => f.BasRolOyuncuID).OnDelete(DeleteBehavior.NoAction);
            #endregion
            #region Yonetmen
            modelBuilder.Entity<Yonetmen>().HasKey(y => y.ID);
            modelBuilder.Entity<Yonetmen>().Property(y => y.Ad).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Yonetmen>().Property(y => y.Soyad).IsRequired().HasMaxLength(50);
            #endregion
            #region Kullanici
            modelBuilder.Entity<Kullanici>().HasKey(k => k.ID);
            modelBuilder.Entity<Kullanici>().Property(k => k.Ad).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Kullanici>().Property(k => k.Soyad).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Kullanici>().HasIndex(k => k.KullaniciAdi).IsUnique();
            modelBuilder.Entity<Kullanici>().Property(k => k.KullaniciAdi).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Kullanici>().Property(k => k.Sifre).IsRequired().HasMaxLength(100);
            #endregion
            #region Seans
            modelBuilder.Entity<Seans>().HasKey(s => s.ID);
            modelBuilder.Entity<Seans>().Property(s => s.Fiyat).HasColumnType("decimal(18,2)").IsRequired();
            modelBuilder.Entity<Seans>().HasOne(s => s.Film).WithMany().HasForeignKey(s => s.FilmID).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Seans>().HasOne(s => s.Salon).WithMany(S => S.Seanslar).HasForeignKey(s => s.SalonID).OnDelete(DeleteBehavior.NoAction);
            #endregion
            #region Salon
            modelBuilder.Entity<Salon>().HasKey(s => s.ID);
            modelBuilder.Entity<Salon>().Property(s => s.SalonNo).IsRequired();
            modelBuilder.Entity<Salon>().HasIndex(s => s.SalonNo).IsUnique();
            #endregion
            #region Bilet
            modelBuilder.Entity<Bilet>().HasKey(b => b.ID);
            modelBuilder.Entity<Bilet>().HasIndex(b => new { b.SeansID, b.KoltukID }).IsUnique();
            modelBuilder.Entity<Bilet>().Property(b => b.Fiyat).IsRequired();
            modelBuilder.Entity<Bilet>().HasOne(b => b.Kullanici).WithMany().HasForeignKey(b => b.KullaniciID).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Bilet>().HasOne(b => b.Seans).WithMany().HasForeignKey(b => b.SeansID).OnDelete(DeleteBehavior.NoAction);

            #endregion
            #region Oyuncu
            modelBuilder.Entity<Oyuncu>().HasKey(o => o.ID);
            modelBuilder.Entity<Oyuncu>().Property(o => o.Ad).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Oyuncu>().Property(o => o.Soyad).IsRequired().HasMaxLength(50);
            #endregion
            #region Kategori
            var kategoriler = modelBuilder.Entity<Kategori>();
            kategoriler.HasKey(k => k.ID);
            kategoriler.Property(k => k.Aciklama).HasMaxLength(1000);
            // modelBuilder.Entity<Kategori>().HasMany(k=>k.Filmler).WithOne(f=>f.Kategori); gereksiz tekrar
            #endregion
            #region Koltuk
            var koltuklar = modelBuilder.Entity<Koltuk>();
            koltuklar.HasKey(k => k.ID);
            koltuklar.HasOne(k => k.Salon).WithMany(s => s.Koltuklar).HasForeignKey(k => k.SalonID);
            koltuklar.HasIndex(k => new { k.Numara, k.Satir, k.SalonID }).IsUnique();
            #endregion
            base.OnModelCreating(modelBuilder);
        }
    }
}
