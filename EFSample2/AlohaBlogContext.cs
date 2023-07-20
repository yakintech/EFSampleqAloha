using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSample2
{
    public class AlohaBlogContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-EET2RGT; Database=AlohaBlog; trusted_connection=true");
        }

        public DbSet<Blog> Blogs { get; set; }
    }
}
