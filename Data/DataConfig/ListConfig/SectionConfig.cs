using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp_Semus.Entities.Lists;

namespace WebApp_Semus.Data.DataConfig.ListConfig
{
    public class SectionConfig : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            _ = builder
                .Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
