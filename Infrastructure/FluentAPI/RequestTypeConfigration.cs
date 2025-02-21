using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.FluentAPI
{
    public class RequestTypeConfigration : IEntityTypeConfiguration<RequestType>
    {
        public void Configure(EntityTypeBuilder<RequestType> builder)
        {
            builder.ToTable("RequestType");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(30);


            builder.HasMany(x => x.Request)
                .WithOne(x => x.RequestType)
                .HasForeignKey(x => x.Id);
        }
    }
}
