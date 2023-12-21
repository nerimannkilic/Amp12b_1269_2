using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip2.Models
{
    public static class Db
    {
        public static AppDbContext Context;

        public static void Initialize()
        {
            Context = new AppDbContext();
            Context.Database.EnsureCreated(); //Veritabanını ve tablolaları oluşturur
        }
    }
}
