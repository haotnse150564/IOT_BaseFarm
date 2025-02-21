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
    public class RequestConfigration : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.ToTable("Request");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.UserId).IsRequired().HasMaxLength(10);
            builder.Property(X => X.Title).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Reason).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.AppovedBy).HasMaxLength(10);


            //Relations
            builder.HasOne(x => x.Users)
                .WithMany(x => x.requests)
                .HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.RequestType)
                .WithMany(x => x.Request)
                .HasForeignKey(x => x.RequestTypeID);
        }
    }
}
