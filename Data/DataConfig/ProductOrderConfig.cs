using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp_Semus.Entities.Stock;

namespace WebApp_Semus.Data.DataConfig
{
    public class ProductOrderConfig : IEntityTypeConfiguration<ProductOrder>
    {
        public void Configure(EntityTypeBuilder<ProductOrder> builder)
        {
            _ = builder.HasKey(k => new { k.MedicamentID, k.StockOrderID });

            _ = builder
                .HasOne(s => s.StockOrder)
                .WithMany(t => t.ProductOrders)
                .HasForeignKey(k => k.StockOrderID);

            _ = builder
                .HasOne(s => s.Medicament)
                .WithMany()
                .HasForeignKey(k => k.MedicamentID);
        }
    }
}
