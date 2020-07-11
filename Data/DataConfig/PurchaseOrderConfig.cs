using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp_Semus.Entities.Stock.Purchase;

namespace WebApp_Semus.Data.DataConfig
{
    public class PurchaseOrderConfig : IEntityTypeConfiguration<PurchaseOrder>
    {
        public void Configure(EntityTypeBuilder<PurchaseOrder> builder)
        {
            _ = builder
                .HasOne(s => s.IdentityUser)
                .WithMany()
                .HasForeignKey(k => k.UserID);

            _ = builder
                .HasOne(s => s.Stock)
                .WithMany(t => t.PurchaseOrders)
                .HasForeignKey(k => k.StockID);
        }
    }
}
