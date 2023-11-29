using Domain.Entities.ProductEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Configurations
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { }

        //for product
        public DbSet<Product> Products => Set<Product>();
        public DbSet<ProductType> ProductType => Set<ProductType>();
        public DbSet<ProductBrand> ProductBrand => Set<ProductBrand>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //if is deleted equal true continue
            //modelBuilder.Entity<Product>().HasQueryFilter(x => x.IsDelete == false);
            //modelBuilder.Entity<ProductBrand>().HasQueryFilter(x => x.IsDelete == false);
            //modelBuilder.Entity<ProductType>().HasQueryFilter(x => x.IsDelete == false);
            //modelBuilder.Entity<Address>().HasQueryFilter(x => x.IsDelete == false);
            //modelBuilder.Entity<Order>().HasQueryFilter(x => x.IsDelete == false);
            //modelBuilder.Entity<DeliveryMethod>().HasQueryFilter(x => x.IsDelete == false);
            //modelBuilder.Entity<OrderItem>().HasQueryFilter(x => x.IsDelete == false);
        }
    }
}
