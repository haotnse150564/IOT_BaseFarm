using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.FluentAPI
{
    public class InventoryCategoryConfigration : IEntityTypeConfiguration<InventoryCategory>
    {
        public void Configure(EntityTypeBuilder<InventoryCategory> builder)
        {
            builder.ToTable("InventoryCategory");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(30);


            builder.HasMany(x => x.Inventory)
                .WithOne(x => x.InventoryCategories)
                .HasForeignKey(x => x.CategoryId);
        }
    }
}
