using MeetingRoomsBooking.Models.Base;

namespace MeetingRoomsBooking.Models.Dtos
{
    public class UpdateRoomDto : CreateRoomDto, IHasId
    {
        public int Id { get; set; }
    }
}
