using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.FluentAPIs
{
    public class InvoiceConfigration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.ToTable("Invoice");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.VoucherId).IsRequired(false);
            builder.Property(x => x.Payment).HasMaxLength(1);
            builder.Property(x => x.Total).HasMaxLength(10);
            builder.Property(x => x.UserId).HasMaxLength(10);


            //Relations
            builder.HasOne(x => x.Users)
                .WithMany(x => x.invoices)
                .HasForeignKey(x => x.UserId);

            builder.HasMany(x => x.InvoiceDetails)
                .WithOne(x => x.Invoice)
                .HasForeignKey(x => x.InvoiceId);

            builder.HasOne(x => x.voucher)
                .WithMany(x => x.invoice)
                .OnDelete(DeleteBehavior.SetNull);
                
        }
    }
}
