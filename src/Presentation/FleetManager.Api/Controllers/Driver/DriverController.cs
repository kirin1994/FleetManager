using FleetManager.Application;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace FleetManager.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DriverController : ControllerBase
    {       
        private readonly ILogger<DriverController> _logger;
        private readonly IMediator _mediator;

        public DriverController(ILogger<DriverController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet("{driverId}")]
        public async Task<IActionResult> GetDriverById(Guid driverId)
        {
            var driver = await _mediator.Send(new GetDriverByIdQuery(driverId));
            return driver == null ? NotFound() : Ok(driver);
        }
    }
}
