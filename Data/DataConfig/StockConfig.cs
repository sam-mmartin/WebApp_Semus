using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp_Semus.Entities.Stock;

namespace WebApp_Semus.Data.DataConfig
{
    public class StockConfig : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            _ = builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            _ = builder
                .HasOne(s => s.IdentityUser)
                .WithMany()
                .HasForeignKey(k => k.UserID);
        }
    }
}
