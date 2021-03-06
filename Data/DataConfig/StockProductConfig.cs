﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp_Semus.Entities.Stock;

namespace WebApp_Semus.Data.DataConfig
{
    public class StockProductConfig : IEntityTypeConfiguration<StockProduct>
    {
        public void Configure(EntityTypeBuilder<StockProduct> builder)
        {
            _ = builder.HasKey(k => new { k.StockID, k.MedicamentID });

            _ = builder
                .HasOne(s => s.Stock)
                .WithMany(c => c.StockProducts)
                .HasForeignKey(k => k.StockID);

            _ = builder
                .HasOne(s => s.Medicament)
                .WithMany(c => c.StockProducts)
                .HasForeignKey(k => k.MedicamentID);

            _ = builder
                .HasOne(s => s.IdentityUser)
                .WithMany()
                .HasForeignKey(k => k.UserID);
        }
    }
}
