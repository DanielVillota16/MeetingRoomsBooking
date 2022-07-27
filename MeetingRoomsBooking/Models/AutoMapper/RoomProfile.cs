using AutoMapper;
using MeetingRoomsBooking.Models.Dtos;
using MeetingRoomsBooking.Models.Entities;

namespace MeetingRoomsBooking.Models.AutoMapper
{
    public class RoomProfile : Profile
    {
        public RoomProfile()
        {
            CreateMap<CreateRoomDto, Room>();
            CreateMap<UpdateRoomDto, Room>();
            CreateMap<Room, RoomDto>();
        }
    }
}
