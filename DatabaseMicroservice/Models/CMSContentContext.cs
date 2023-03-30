using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMicroservice.Models
{
    internal class CMSContentContext : DbContext
    {
        public DbSet<TextFragment> TextFragments { get; set; }
        public DbSet<APIKey> APIKeys { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(
                optionsBuilder.UseMySql(@"Server=localhost;Port=3306;user=forger;password=turpentine;database=cmscontent.mariadb",ServerVersion.AutoDetect(@"Server=localhost;Port=3306;user=forger;password=turpentine;database=cmscontent.mariadb"))
                );
        }
    }
}
