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
    public class ProfitConfigration : IEntityTypeConfiguration<Profit>
    {
        public void Configure(EntityTypeBuilder<Profit> builder)
        {
            builder.ToTable(nameof(Profit));
            builder.HasKey(p => p.Id);
            builder.Property(x => x.TotalSalary).HasMaxLength(10);
            builder.Property(x => x.ToTalRevenue).HasMaxLength(10);
            builder.Property(x => x.TotalImport).HasMaxLength(10);
            builder.Property(x => x.Order).HasMaxLength(10);
            builder.Property(x => x.Month).HasMaxLength(2);
            builder.Property(x => x.Year).HasMaxLength(2);

            builder.HasMany(x => x.Salary)
                .WithOne(x => x.Profit)
                .HasForeignKey(x => x.ProfitId);

            builder.HasMany(x => x.Invoices)
                .WithOne(x => x.Profit)
                .HasForeignKey(x => x.ProfitID);

            builder.HasMany(x => x.Imports)
                .WithOne(x => x.profit)
                .HasForeignKey(x => x.ProfitID);
        }
    }
}
