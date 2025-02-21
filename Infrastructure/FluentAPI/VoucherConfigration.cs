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
    public class VoucherConfigration : IEntityTypeConfiguration<Voucher>
    {
        public void Configure(EntityTypeBuilder<Voucher> builder)
        {
            builder.ToTable("Voucher");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.TypeDiscount).IsRequired().HasMaxLength(1);
            builder.Property(x => x.Value).IsRequired().HasMaxLength(10);
            builder.Property(x => x.isActive).IsRequired();

            //Relations
            builder.HasMany(x => x.invoice)
                .WithOne(x => x.voucher);
        }
    }
}
