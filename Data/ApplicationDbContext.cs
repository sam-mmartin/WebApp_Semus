﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp_Semus.Data.DataConfig;
using WebApp_Semus.Entities.Stock;
using WebApp_Semus.Entities.Stock.Order;
using WebApp_Semus.Entities.Stock.Purchase;

namespace WebApp_Semus.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }
        public DbSet<ProductPurchaseOrder> ProductPurchaseOrders { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<StockOrder> StockOrders { get; set; }
        public DbSet<StockProduct> StockProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new StockConfig());

            base.OnModelCreating(builder);
        }
    }
}