using Microsoft.EntityFrameworkCore;
using MixPractices.App.Entities;
using MixPractices.App.Entities.ManyToMany;
using MixPractices.App.Entities.OneToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixPractices.App.Context
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Cource;Integrated Security=true;TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Citizen>()
                .HasOne<Passport>(x => x.passport)
                .WithOne(x => x.Citizen)
                .HasForeignKey<Passport>(x => x.CitizenId);
            modelBuilder.Entity<Product>()
                .HasOne<SubCategory>(x => x.subcategory)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.subcategoryId);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Citizen> Citizens {  get; set; }
        public DbSet<Passport> Passports { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<SubCategory>SubCategories { get; set; }
        public DbSet<Product>Products { get; set; }
        public DbSet<Book>Books { get; set; }
        public DbSet<Author>Authors { get; set; }
    }
}
