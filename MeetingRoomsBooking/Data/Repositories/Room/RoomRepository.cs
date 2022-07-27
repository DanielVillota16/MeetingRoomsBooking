using MeetingRoomsBooking.Data.Base;
using MeetingRoomsBooking.Models.Entities;

namespace MeetingRoomsBooking.Data.Repositories
{
    public class RoomRepository : RepositoryBase<Room, ApplicationDbContext>, IRoomRepository
    {
        public RoomRepository(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
