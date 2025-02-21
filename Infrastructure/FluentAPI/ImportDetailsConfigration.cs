using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.FluentAPIs
{
    public class ImportDetailsConfigration : IEntityTypeConfiguration<ImportDetails>
    {
        public void Configure(EntityTypeBuilder<ImportDetails> builder)
        {
            builder.ToTable("ImportDetails");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Quantity).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Price).HasMaxLength(10);
            builder.Property(x => x.InventoryId).HasMaxLength(10);
            builder.Property(x => x.ImportId).HasMaxLength(10);


            //Relations
            builder.HasOne(x => x.Import)
                .WithMany(x => x.importDetails)
                .HasForeignKey(x => x.ImportId);

            builder.HasOne(x => x.Inventory)
                .WithMany(x => x.ImportDetails)
                .HasForeignKey(x => x.InventoryId);
        }
    }
}
