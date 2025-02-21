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
    public class UserConfigration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(t => t.Id);
            builder.Property(x => x.FullName).IsRequired().HasMaxLength(30);
            builder.Property(x => x.StartToWork).IsRequired();
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Password).IsRequired();
            builder.Property(x => x.Address).IsRequired().HasMaxLength(100);  
            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.ContractExpiration).IsRequired();
            builder.Property(x => x.CofficientsSalary).HasMaxLength(10);




            //Relations
            builder.HasMany(x => x.UserWorkSheets)
                .WithOne(x => x.Users)
                .HasForeignKey(x => x.UserId);

            builder.HasMany(x => x.requests)
               .WithOne(x => x.Users)
               .HasForeignKey(x => x.UserId);

            builder.HasMany(x => x.Punishments)
               .WithOne(x => x.Users)
               .HasForeignKey(x => x.UserId);

            builder.HasMany(x => x.imports)
               .WithOne(x => x.Users)
               .HasForeignKey(x => x.UserId);

            builder.HasMany(x => x.damagesAssets)
               .WithOne(x => x.Users)
               .HasForeignKey(x => x.UserId);

            builder.HasMany(x => x.invoices)
               .WithOne(x => x.Users)
               .HasForeignKey(x => x.UserId);

            builder.HasMany(x => x.overTimeWorkSheets)
               .WithOne(x => x.Users)
               .HasForeignKey(x => x.UserId);
        }
    }
}
