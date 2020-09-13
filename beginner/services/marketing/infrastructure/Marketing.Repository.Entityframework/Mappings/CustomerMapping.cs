using Marketing.Domain;
using Marketing.Domain.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Marketing.Repository.EntityFramework.Mappings
{
    public static class CustomerMapping
    {
        public static void ConfigCustomerMapping(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));
 
            builder.Entity<Customer>(b =>
            {
                b.ToTable("Customer");
                b.ConfigureConcurrencyStamp();
                b.ConfigureExtraProperties();
                b.ConfigureAudited();

                b.Property(x => x.Name).IsRequired().HasMaxLength(30);
                b.Property(x => x.Mobile).IsRequired().HasMaxLength(11);
                b.Property(x => x.Gender).HasMaxLength(1)
                .HasConversion(   
                    v => v.ToString(),
                    v => (Gender)Enum.Parse(typeof(Gender), v));

                b.HasMany(x => x.Labels).WithOne().OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
