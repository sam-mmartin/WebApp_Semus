using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp_Semus.Entities.Lists;

namespace WebApp_Semus.Data.DataConfig.ListConfig
{
    public class PharmacologicalGroupConfig : IEntityTypeConfiguration<PharmacologicalGroup>
    {
        public void Configure(EntityTypeBuilder<PharmacologicalGroup> builder)
        {
            _ = builder
                .Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(100);

            _ = builder
                .HasOne(s => s.Section)
                .WithMany()
                .HasForeignKey(k => k.SectionID);
        }
    }
}
