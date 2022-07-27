using MeetingRoomsBooking.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeetingRoomsBooking.Models.Entities
{
    [Table("ASISTENTES")]
    public class Assistant : IHasId
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column("RESERVA_ID")]
        public int? ReservationId { get; set; }

        public Reservation? Reservation { get; set; }

        [Column("ASISTENTE_ID")]
        public int EmployeeId { get; set; }

        public Employee? Employee { get; set; }

        [Column("ASISTIO")]
        [Required]
        public bool Assisted { get; set; }
    }
}
