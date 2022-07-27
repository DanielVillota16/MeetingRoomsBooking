using System.ComponentModel.DataAnnotations;

namespace MeetingRoomsBooking.Models.Dtos
{
    public class CreateAssistantDto
    {
        public int ReservationId { get; set; }

        public int EmployeeId { get; set; }

        [Required]
        public bool Assisted { get; set; }
    }
}
