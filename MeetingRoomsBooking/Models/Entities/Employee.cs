using MeetingRoomsBooking.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeetingRoomsBooking.Models.Entities
{
    [Table("EMPLEADO")]
    public class Employee : IHasId
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column("NOMBRE_COMPLETO")]
        [Required]
        [MaxLength(30)]
        public string FullName { get; set; }

        [Column("CARGO")]
        [Required]
        [MaxLength(30)]
        public string Position { get; set; }
    }
}
