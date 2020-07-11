using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp_Semus.Entities.Stock.Purchase;

namespace WebApp_Semus.Data.DataConfig
{
    public class ProductPurchaseOrderConfig : IEntityTypeConfiguration<ProductPurchaseOrder>
    {
        public void Configure(EntityTypeBuilder<ProductPurchaseOrder> builder)
        {
            _ = builder.HasKey(k => new { k.ProductID, k.PurchaseOrderID });

            _ = builder
                .HasOne(s => s.PurchaseOrder)
                .WithMany(t => t.ProductPurchaseOrders)
                .HasForeignKey(k => k.PurchaseOrderID);

            _ = builder
                .HasOne(s => s.Product)
                .WithMany()
                .HasForeignKey(k => k.ProductID);
        }
    }
}
