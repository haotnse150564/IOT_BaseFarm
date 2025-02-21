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
    public class UserWorkSheetConfigration : IEntityTypeConfiguration<UserWorkSheet>
    {
        public void Configure(EntityTypeBuilder<UserWorkSheet> builder)
        {
           builder.ToTable("UserWorkSheet");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.Attend).IsRequired();
            builder.Property(x => x.UserId).HasMaxLength(10);
            builder.Property(x => x.WorkSheetId).HasMaxLength(10);
            builder.Property(x => x.SalaryID).HasMaxLength(10);

            //Relations
            builder.HasOne(x => x.WorkSheets)
                .WithMany(x => x.UserWorkSheet)
                .HasForeignKey(x => x.WorkSheetId);

            builder.HasOne(x => x.Users)
                .WithMany(x => x.UserWorkSheets)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
