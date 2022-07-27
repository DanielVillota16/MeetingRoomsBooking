using System.ComponentModel.DataAnnotations;

namespace MeetingRoomsBooking.Models.Dtos
{
    public class EmployeeDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(30)]
        public string Position { get; set; }
    }
}
