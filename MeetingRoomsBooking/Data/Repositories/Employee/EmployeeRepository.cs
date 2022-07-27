using MeetingRoomsBooking.Data.Base;
using MeetingRoomsBooking.Models.Entities;

namespace MeetingRoomsBooking.Data.Repositories
{
    public class EmployeeRepository : RepositoryBase<Employee, ApplicationDbContext>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
