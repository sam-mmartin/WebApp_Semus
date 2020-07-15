using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp_Semus.Entities.Stock.Purchase;

namespace WebApp_Semus.Data.DataConfig
{
    public class ProductPurchaseOrderConfig : IEntityTypeConfiguration<ProductPurchaseOrder>
    {
        public void Configure(EntityTypeBuilder<ProductPurchaseOrder> builder)
        {
            _ = builder.HasKey(k => new { k.MedicamentID, k.PurchaseOrderID });

            _ = builder
                .HasOne(s => s.PurchaseOrder)
                .WithMany(t => t.ProductPurchaseOrders)
                .HasForeignKey(k => k.PurchaseOrderID);

            _ = builder
                .HasOne(s => s.Medicament)
                .WithMany()
                .HasForeignKey(k => k.MedicamentID);
        }
    }
}
