using Marketing.Domain;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Marketing.Repository.EntityFramework.Mappings
{
    public static class CustomerLabelMapping
    {
        public static void ConfigCustomerLabelMapping(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));
            builder.Entity<CustomerLabel>(b =>
            {
                b.ToTable("CustomerLabel");
                b.HasKey(x=>x.Id);
                
                b.Property(x => x.Name).IsRequired().HasMaxLength(30);
                //b.Property(x => x.CustomerId).IsRequired();

                b.HasOne(x => x.Customer)
                    .WithMany(x => x.Labels)
                    .HasForeignKey(x => x.CustomerId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
