using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp_Semus.Entities.Lists;

namespace WebApp_Semus.Data.DataConfig.ListConfig
{
    public class SecondSubGroupConfig : IEntityTypeConfiguration<SecondSubGroup>
    {
        public void Configure(EntityTypeBuilder<SecondSubGroup> builder)
        {
            _ = builder
                .Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(150);

            _ = builder
                .HasOne(p => p.FirstSubGroup)
                .WithMany()
                .HasForeignKey(k => k.FirstSubGroupID);
        }
    }
}
