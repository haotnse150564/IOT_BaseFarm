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
    public class ImportConfigration : IEntityTypeConfiguration<Import>
    {
        public void Configure(EntityTypeBuilder<Import> builder)
        {
            builder.ToTable("Import");

            //Attri
            builder.HasKey(x => x.Id);

            builder.Property(x => x.UserId).IsRequired().HasMaxLength(10);

            builder.Property(x => x.Price).IsRequired().HasMaxLength(10);

            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.ProfitID).HasMaxLength(10);


            //1User - MImport
            builder.HasOne(x => x.Users)
                .WithMany(x => x.imports)
                .HasForeignKey(x => x.UserId);
            //MImportDetail - 1Import
            builder.HasMany(x => x.importDetails)
                .WithOne(x => x.Import)
                .HasForeignKey(x => x.ImportId);
        }
    }
}
