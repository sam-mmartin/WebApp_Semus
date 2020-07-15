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
                .IsRequired();

            _ = builder
                .HasOne(s => s.IdentityUser)
                .WithMany()
                .HasForeignKey(k => k.UserID);

            _ = builder
                .HasOne(s => s.PharmacologicalGroup)
                .WithMany(p => p.Medicaments)
                .HasForeignKey(k => k.PharmacologicalGroupID);
        }
    }
}
