using FleetManager.Application.Driver.Dto;
using MediatR;
using System;

namespace FleetManager.Application
{
    public class GetDriverByIdQuery : IRequest<DriverResponse>
    {
        public Guid Id { get; }
        public GetDriverByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
