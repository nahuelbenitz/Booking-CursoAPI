using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tarker.Booking.Domain.Entities.User;

namespace Tarker.Booking.Persistence.Configuration
{
    public class UserConfiguration
    {
        public UserConfiguration(EntityTypeBuilder<UserEntity> entity)
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.FirstName).IsRequired();
            entity.Property(x => x.LastName).IsRequired();
            entity.Property(x => x.UserName).IsRequired();
            entity.Property(x => x.Password).IsRequired();

            entity.HasMany(x => x.Bookings).WithOne(x => x.User).HasForeignKey(x => x.UserId);
        }
    }
}
