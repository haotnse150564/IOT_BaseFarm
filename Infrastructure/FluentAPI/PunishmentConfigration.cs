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
    public class PunishmentConfigration : IEntityTypeConfiguration<Punishment>
    {
        public void Configure(EntityTypeBuilder<Punishment> builder)
        {
            builder.ToTable("Punishment");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Reason).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Fine).HasMaxLength(5);
            builder.Property(x => x.UserId).HasMaxLength(10);

            //Relations
            builder.HasOne(x => x.Users)
                .WithMany(x => x.Punishments)
                .HasForeignKey(x => x.UserId);
        }
    }
}
