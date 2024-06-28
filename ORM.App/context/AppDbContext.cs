using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.App.context
{
    public class AppDbContext:DbContext
    {public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        
            optionsBuilder.UseSqlServer("Server = .; Database = OrmInro; Integrated Security=true; TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
