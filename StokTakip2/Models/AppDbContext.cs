using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip2.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Müşteri> Müşteriler { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Satış> Satışlar { get; set; }
        public DbSet<SatışDetayı> SatışDetayları { get; set; }
        public DbSet<Tedarikçi> Tedarikçiler { get; set; }
        public DbSet<Ürün> Ürünler { get; set; }
        public DbSet<Yetki> Yetkiler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=|DataDirectory|Db.mdf;")
                .UseLazyLoadingProxies();
        }
    }
}
