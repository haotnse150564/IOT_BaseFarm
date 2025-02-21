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
    public class InvoiceDetailsConfigration : IEntityTypeConfiguration<InvoiceDetails>
    {
        public void Configure(EntityTypeBuilder<InvoiceDetails> builder)
        {
            builder.ToTable("InvoiceDetails");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.InvoiceId).IsRequired();
            builder.Property(x => x.ProductId).IsRequired();
            builder.Property(x => x.Quantity).HasMaxLength(2);
            builder.Property(x => x.Price).HasMaxLength(10);
            builder.Property(x => x.Total).HasMaxLength(10);



            //Relations
            builder.HasOne(x => x.Invoice)
                .WithMany(x => x.InvoiceDetails)
                .HasForeignKey(x => x.InvoiceId);

            builder.HasOne(x => x.Product)
                .WithMany(x => x.InvoiceDetails)
                .HasForeignKey(x => x.ProductId);

        }
    }
}
