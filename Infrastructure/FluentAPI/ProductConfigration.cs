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
    public class ProductConfigrationc : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Price).HasMaxLength(3);
            builder.Property(x => x.Name).HasMaxLength(30);
            builder.Property(x => x.Status).IsRequired().HasMaxLength(1);
            builder.Property(x => x.OutOfStock).IsRequired();
            builder.Property(x => x.ProductImg);
            
            //Relations
            builder.HasMany(x => x.InvoiceDetails)
                .WithOne(x => x.Product)
                .HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.ProductCategory)
                .WithMany(x => x.product)
                .HasForeignKey(x => x.CategoryId);
        }
    }
}
