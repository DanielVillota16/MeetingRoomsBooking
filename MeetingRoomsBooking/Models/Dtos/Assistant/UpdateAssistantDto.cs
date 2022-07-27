using MeetingRoomsBooking.Models.Base;

namespace MeetingRoomsBooking.Models.Dtos
{
    public class UpdateAssistantDto : CreateAssistantDto, IHasId
    {
        public int Id { get; set; }
    }
}
