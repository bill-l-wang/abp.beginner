using Marketing.Domain;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Marketing.Repository.Entityframework.Mappings
{
    public static class CustomerLabelMapping
    {
        public static void ConfigCustomerMapping(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));
            builder.Entity<CustomerLabel>(b =>
            {
                b.ToTable("CustomerLabel");
                b.Property(x => x.Name).IsRequired().HasMaxLength(30);
                b.Property(x => x.CustomerId).IsRequired();
            });
        }
    }
}
