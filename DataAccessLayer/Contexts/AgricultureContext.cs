using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contexts
{
    public class AgricultureContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-6NS5JFO\\SQLEXPRESS;database=DbAgriculture;uid=sa;pwd=1234;TrustServerCertificate=True");
        }

        public DbSet<Service> Services { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contant> Contants { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Announcement> Announcements { get; set; }


    }
}
