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
    public class DamagesAssetConfigration : IEntityTypeConfiguration<DamagesAsset>
    {
        public void Configure(EntityTypeBuilder<DamagesAsset> builder)
        {
            builder.ToTable("DamagesAsset");

            //Attribute
            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.NameAsset).IsRequired();

            builder.Property(x => x.Quantity).IsRequired();


            //Relation 1User - MDame
            builder.HasOne(x => x.Users)
                    .WithMany(x => x.damagesAssets)
                    .HasForeignKey(x => x.UserId);
        }
    }
}
