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
    public class ProductCategoryConfigration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("ProductCategory");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(30);


            builder.HasMany(x => x.product)
                .WithOne(x => x.ProductCategory)
                .HasForeignKey(x => x.Id);
        }
    }
}
