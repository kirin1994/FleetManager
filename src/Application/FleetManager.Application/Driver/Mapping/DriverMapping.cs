using AutoMapper;
using FleetManager.Application.Driver.Dto;

namespace FleetManager.Application.Driver.Mapping
{
    public class DriverMapping : Profile
    {
        public DriverMapping()
        {
            CreateMap<Core.Models.Driver, DriverResponse>();
        }
    }
}
