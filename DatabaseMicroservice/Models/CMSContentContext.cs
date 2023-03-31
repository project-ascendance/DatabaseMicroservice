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
        public DbSet<ActiverFromFragment> ActiverFromFragments { get; set; }
        public DbSet<ExternalFragment> ExternalFragments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(
                optionsBuilder.UseMySql(@"Server=localhost;Port=3306;user=forger;password=turpentine;database=cmscontent.mariadb",ServerVersion.Create(new Version(10,11,2),Pomelo.EntityFrameworkCore.MySql.Infrastructure.ServerType.MariaDb))
                );
        }
    }
}
