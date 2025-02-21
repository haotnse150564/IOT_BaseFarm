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
    public class OverTimeWorkSheetConfigration : IEntityTypeConfiguration<OverTimeWorkSheet>
    {
        public void Configure(EntityTypeBuilder<OverTimeWorkSheet> builder)
        {
            builder.ToTable("OverTimeWorkSheet");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.UserId).IsRequired().HasMaxLength(10);
            builder.Property(x => x.StartTime).IsRequired();
            builder.Property(x => x.EndTime).IsRequired();
            builder.Property(x => x.Total).HasMaxLength(2);

            //Relations
            builder.HasOne(x => x.Users)
                .WithMany(x => x.overTimeWorkSheets)
                .HasForeignKey(x => x.UserId);


        }
    }
}
