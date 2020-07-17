using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp_Semus.Entities.Lists;

namespace WebApp_Semus.Data.DataConfig.ListConfig
{
    public class ThirdSubGroupConfig : IEntityTypeConfiguration<ThirdSubGroup>
    {
        public void Configure(EntityTypeBuilder<ThirdSubGroup> builder)
        {
            _ = builder
                .Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(150);

            _ = builder
                .HasOne(p => p.SecondSubGroup)
                .WithMany()
                .HasForeignKey(k => k.SecondSubGroupID);
        }
    }
}
