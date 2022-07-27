using AutoMapper;
using MeetingRoomsBooking.Models.Dtos;
using MeetingRoomsBooking.Models.Entities;

namespace MeetingRoomsBooking.Models.AutoMapper
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<CreateEmployeeDto, Employee>();
            CreateMap<UpdateEmployeeDto, Employee>();
            CreateMap<Employee, EmployeeDto>();
        }
    }
}
