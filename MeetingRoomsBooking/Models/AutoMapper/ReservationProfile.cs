using AutoMapper;
using MeetingRoomsBooking.Models.Dtos;
using MeetingRoomsBooking.Models.Entities;

namespace MeetingRoomsBooking.Models.AutoMapper
{
    public class ReservationProfile : Profile
    {
        public ReservationProfile()
        {
            CreateMap<CreateReservationDto, Reservation>();
            CreateMap<UpdateReservationDto, Reservation>();
            CreateMap<Reservation, ReservationDto>();
        }
    }
}
