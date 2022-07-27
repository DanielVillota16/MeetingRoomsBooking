using MeetingRoomsBooking.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace MeetingRoomsBooking.Models.Entities
{
    public class Employee : IHasId
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
