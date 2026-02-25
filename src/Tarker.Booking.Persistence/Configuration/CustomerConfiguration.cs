using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tarker.Booking.Domain.Entities.Customer;

namespace Tarker.Booking.Persistence.Configuration
{
    public class CustomerConfiguration
    {
        public CustomerConfiguration(EntityTypeBuilder<CustomerEntity> entity)
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.FullName).IsRequired();
            entity.Property(x => x.DocumentNumber).IsRequired();

            entity.HasMany(x => x.Bookings).WithOne(x => x.Customer).HasForeignKey(x => x.CustomerId);

        }
    }
}
