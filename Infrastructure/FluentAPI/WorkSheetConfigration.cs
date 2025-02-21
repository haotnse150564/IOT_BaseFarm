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
    public class WorkSheetConfigration : IEntityTypeConfiguration<WorkSheet>
    {
        public void Configure(EntityTypeBuilder<WorkSheet> builder)
        {
            builder.ToTable("WorkSheet");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Shift).IsRequired().HasMaxLength(1);
            builder.Property(x => x.Status).IsRequired();

            //Relations
            builder.HasMany(x => x.UserWorkSheet)
                .WithOne(x => x.WorkSheets)
                .HasForeignKey(x => x.WorkSheetId);

        }
    }
}
