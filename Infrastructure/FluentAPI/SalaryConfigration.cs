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
    public class SalaryConfigration : IEntityTypeConfiguration<Salary>
    {
        public void Configure(EntityTypeBuilder<Salary> builder)
        {
            builder.ToTable(nameof(Salary));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.ProfitId).IsRequired();
            builder.Property(x => x.Month).HasMaxLength(2);
            builder.Property(x => x.Year).HasMaxLength(2);
            builder.Property(x => x.ProfitId).HasMaxLength(10);
            builder.Property(x => x.UserId).HasMaxLength(10);


            builder.HasOne(x => x.Profit)
                .WithMany(x => x.Salary)
                .HasForeignKey(x => x.ProfitId);

            builder.HasMany(x => x.UserWorkSheets)
                .WithOne(x => x.Salary)
                .HasForeignKey(x => x.SalaryID);
            builder.HasOne(x => x.Users)
                .WithMany(x => x.Salaries)
                .HasForeignKey(x => x.UserId);

        }
    }
}
