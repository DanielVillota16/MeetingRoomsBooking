using AutoMapper;
using MeetingRoomsBooking.Models.Dtos;
using MeetingRoomsBooking.Models.Entities;

namespace MeetingRoomsBooking.Models.AutoMapper
{
    public class AssistantProfile : Profile
    {
        public AssistantProfile()
        {
            CreateMap<CreateAssistantDto, Assistant>();
            CreateMap<UpdateAssistantDto, Assistant>();
            CreateMap<Assistant, AssistantDto>();
        }
    }
}
