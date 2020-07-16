using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp_Semus.Entities.Stock;

namespace WebApp_Semus.Data.DataConfig
{
    public class MedicamentConfig : IEntityTypeConfiguration<Medicament>
    {
        public void Configure(EntityTypeBuilder<Medicament> builder)
        {
            _ = builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            _ = builder
                .Property(p => p.PharmaceuticalForm)
                .IsRequired()
                .HasMaxLength(100);

            _ = builder
                .Property(p => p.Availability)
                .IsRequired()
                .HasMaxLength(150);

            _ = builder
                .Property(p => p.Section)
                .IsRequired(false)
                .HasMaxLength(150);

            _ = builder
                .Property(p => p.PharmacologicalGroup)
                .IsRequired(false)
                .HasMaxLength(150);

            _ = builder
                .Property(p => p.FirstSubGroup)
                .IsRequired(false)
                .HasMaxLength(150);

            _ = builder
                .Property(p => p.SecondSubGroup)
                .IsRequired(false)
                .HasMaxLength(150);

            _ = builder
                .Property(p => p.ThirdSubGroup)
                .IsRequired(false)
                .HasMaxLength(150);

            _ = builder
                .HasOne(s => s.IdentityUser)
                .WithMany()
                .HasForeignKey(k => k.UserID);
        }
    }
}
