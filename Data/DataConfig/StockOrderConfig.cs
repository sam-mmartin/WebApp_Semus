using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp_Semus.Entities.Stock.Order;

namespace WebApp_Semus.Data.DataConfig
{
    public class StockOrderConfig : IEntityTypeConfiguration<StockOrder>
    {
        public void Configure(EntityTypeBuilder<StockOrder> builder)
        {
            _ = builder
                .HasOne(s => s.IdentityUser)
                .WithMany()
                .HasForeignKey(k => k.UserID);

            _ = builder
                .HasOne(s => s.Stock)
                .WithMany(t => t.StockOrders)
                .HasForeignKey(k => k.StockID);
        }
    }
}
