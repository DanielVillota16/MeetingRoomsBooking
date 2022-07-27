using MeetingRoomsBooking.Models.Base;

namespace MeetingRoomsBooking.Models.Dtos
{
    public class UpdateEmployeeDto : CreateEmployeeDto, IHasId
    {
        public int Id { get; set; }
    }
}
