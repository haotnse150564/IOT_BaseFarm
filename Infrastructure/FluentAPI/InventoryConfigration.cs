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
    public class InventoryConfigration : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder.ToTable("Inventory");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Quantity).IsRequired().HasMaxLength(5);
            builder.Property(x => x.isInUser).IsRequired();

            //Relations
            builder.HasMany(x => x.ImportDetails)
                .WithOne(x => x.Inventory)
                .HasForeignKey(x => x.InventoryId);

            builder.HasOne(x => x.InventoryCategories)
                .WithMany(x => x.Inventory)
                .HasForeignKey(x => x.CategoryId);
        }
    }
}
