using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaret.Models;

namespace ETicaret.Models
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Magaza> Magazas { get; set; }
        public DbSet<Iller> Illers { get; set; }
        public DbSet<Yorum> Yorums { get; set; }
        public DbSet<Ilceler> Ilcelers { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Yorumcular> Yorumculars { get; set; }
        public DbSet<ETicaret.Models.MagazaKullanici> MagazaKullanici { get; set; }
        public DbSet<Menu> Menus { get; set; }

    }
}

