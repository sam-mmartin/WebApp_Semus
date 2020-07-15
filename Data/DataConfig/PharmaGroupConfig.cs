using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp_Semus.Entities.Stock;

namespace WebApp_Semus.Data.DataConfig
{
    public class PharmaGroupConfig : IEntityTypeConfiguration<PharmacologicalGroup>
    {
        public void Configure(EntityTypeBuilder<PharmacologicalGroup> builder)
        {
            _ = builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            _ = builder
               .Property(p => p.Section)
               .IsRequired(false)
               .HasMaxLength(2);

            _ = builder
               .Property(p => p.SectionName)
               .IsRequired(false);

            _ = builder
               .Property(p => p.FirstSubGroup)
               .IsRequired(false)
               .HasMaxLength(20);

            _ = builder
               .Property(p => p.SecondSubGroup)
               .IsRequired(false)
               .HasMaxLength(20);

            _ = builder
               .Property(p => p.ThirdSubGroup)
               .IsRequired(false)
               .HasMaxLength(20);

            _ = builder
               .Property(p => p.FirstGroupName)
               .IsRequired(false)
               .HasMaxLength(100);

            _ = builder
               .Property(p => p.SecondGroupName)
               .IsRequired(false)
               .HasMaxLength(100);

            _ = builder
               .Property(p => p.ThirdGroupName)
               .IsRequired(false)
               .HasMaxLength(100);

            _ = builder
                .HasOne(s => s.IdentityUser)
                .WithMany()
                .HasForeignKey(k => k.UserID);
        }
    }
}
