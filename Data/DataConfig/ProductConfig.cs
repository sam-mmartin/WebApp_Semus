using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp_Semus.Entities.Stock;

namespace WebApp_Semus.Data.DataConfig
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            _ = builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            _ = builder
                .Property(p => p.PharmaceuticalForm)
                .IsRequired()
                .HasMaxLength(50);

            _ = builder
                .Property(p => p.Type)
                .IsRequired();

            _ = builder
                .HasOne(s => s.IdentityUser)
                .WithMany()
                .HasForeignKey(k => k.UserID);
        }
    }
}
