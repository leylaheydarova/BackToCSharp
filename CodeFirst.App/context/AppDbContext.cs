using CodeFirst.App.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.App.context
{
    public class AppDbContext:DbContext
    {
        public DbSet<Product>Produts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=CodeFirstDb;Integrated Security = true; TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
