using MeetingRoomsBooking.Data.Base;
using MeetingRoomsBooking.Models.Entities;

namespace MeetingRoomsBooking.Data.Repositories
{
    public class AssistantRepository : RepositoryBase<Assistant, ApplicationDbContext>, IAssistantRepository
    {
        public AssistantRepository(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
