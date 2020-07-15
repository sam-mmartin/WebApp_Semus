using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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

        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<PharmacologicalGroup> PharmacologicalGroups { get; set; }

        public DbSet<ProductOrder> ProductOrders { get; set; }
        public DbSet<ProductPurchaseOrder> ProductPurchaseOrders { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<StockOrder> StockOrders { get; set; }
        public DbSet<StockProduct> StockProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            _ = builder.ApplyConfiguration(new MedicamentConfig());
            _ = builder.ApplyConfiguration(new PharmaGroupConfig());

            _ = builder.ApplyConfiguration(new StockConfig());
            _ = builder.ApplyConfiguration(new StockProductConfig());

            _ = builder.ApplyConfiguration(new StockOrderConfig());
            _ = builder.ApplyConfiguration(new ProductOrderConfig());
            _ = builder.ApplyConfiguration(new PurchaseOrderConfig());
            _ = builder.ApplyConfiguration(new ProductPurchaseOrderConfig());

            base.OnModelCreating(builder);
        }
    }
}
