using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineWatchStore.Models;

namespace OnlineWatchStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<InformationOfPurchase> InformationofPurchases { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        // Overide the Model Creating Method
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Product and Category
            builder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .HasConstraintName("FK_Products_CategoryID");

            //Information of Purchase and Product
            builder.Entity<InformationOfPurchase>()
               .HasOne(p => p.Product)
               .WithMany(c => c.InformationOfPurchases)
               .HasForeignKey(p => p.ProductId)
               .HasConstraintName("FK_InformationOfPurchases_Product ID");
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
