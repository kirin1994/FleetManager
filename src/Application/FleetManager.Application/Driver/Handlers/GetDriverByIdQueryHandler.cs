using AutoMapper;
using FleetManager.Application.Driver.Dto;
using FleetManager.Infrastructure.Driver.Persistance;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FleetManager.Application.Driver.Handlers
{
    public class GetDriverByIdQueryHandler : IRequestHandler<GetDriverByIdQuery, DriverResponse>
    {
        private IDriverRepository _driverRepository;
        private IMapper _mapper;

        public GetDriverByIdQueryHandler(IDriverRepository driverRepository, IMapper mapper)
        {
            _driverRepository = driverRepository;
            _mapper = mapper;
        }

        public async Task<DriverResponse> Handle(GetDriverByIdQuery request, CancellationToken cancelationToken)
        {
            var driver = await _driverRepository.GetDriverByIdAsync(request.Id);
            return driver == null ? null : _mapper.Map<DriverResponse>(driver);
        }
    }
}
