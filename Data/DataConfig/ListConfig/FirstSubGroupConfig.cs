using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp_Semus.Entities.Lists;

namespace WebApp_Semus.Data.DataConfig.ListConfig
{
    public class FirstSubGroupConfig : IEntityTypeConfiguration<FirstSubGroup>
    {
        public void Configure(EntityTypeBuilder<FirstSubGroup> builder)
        {
            _ = builder
                .Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(150);

            _ = builder
                .HasOne(p => p.PharmacologicalGroup)
                .WithMany()
                .HasForeignKey(k => k.PharmacologicalGroupID);
        }
    }
}
