using MeetingRoomsBooking.Models.Base;

namespace MeetingRoomsBooking.Models.Dtos
{
    public class UpdateReservationDto : CreateReservationDto, IHasId
    {
        public int Id { get; set; }
    }
}
