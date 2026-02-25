using Tarker.Booking.Domain.Entities.Booking;

namespace Tarker.Booking.Domain.Entities.User
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public ICollection<BookingEntity> Bookings { get; set; }
    }
}
