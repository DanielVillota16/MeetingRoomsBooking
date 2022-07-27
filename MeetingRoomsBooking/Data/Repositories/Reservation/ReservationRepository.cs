using MeetingRoomsBooking.Data.Base;
using MeetingRoomsBooking.Models.Entities;

namespace MeetingRoomsBooking.Data.Repositories
{
    public class ReservationRepository : RepositoryBase<Reservation, ApplicationDbContext>, IReservationRepository
    {
        public ReservationRepository(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
