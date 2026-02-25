using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tarker.Booking.Domain.Entities.Booking;

namespace Tarker.Booking.Persistence.Configuration
{
    public class BookingConfiguration
    {
        public BookingConfiguration(EntityTypeBuilder<BookingEntity> entity)
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.RegisterDate).IsRequired();
            entity.Property(x => x.Code).IsRequired();
            entity.Property(x => x.Type).IsRequired();
            entity.Property(x => x.UserId).IsRequired();
            entity.Property(x => x.CustomerId).IsRequired();

            entity.HasOne(x => x.User).WithMany(x => x.Bookings).HasForeignKey(x => x.UserId);
            entity.HasOne(x => x.Customer).WithMany(x => x.Bookings).HasForeignKey(x => x.CustomerId);
        }
    }
}
