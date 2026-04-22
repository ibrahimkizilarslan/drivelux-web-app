using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DriveLux.Application.Features.Mediator.Commands.LocationCommands;
using DriveLux.Application.Features.Mediator.Queries.LocationQueries;

namespace DriveLux.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly IMediator _mediator;  // Registering handlers via MediatR avoids manual injection.

        public LocationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> LocationList()
        {
            // Send metodu ilgili handlera istek yapar.
            var values = await _mediator.Send(new GetLocationQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetLocation(int id)
        {
            var value = await _mediator.Send(new GetLocationByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]

        public async Task<IActionResult> CreateLocation(CreateLocationCommands command)
        {
            await _mediator.Send(command);
            return Ok("Lokasyon eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveLocation(int id)
        {
            await _mediator.Send(new RemoveLocationCommands(id));
            return Ok("Lokasyon successfully deleted");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateLocation(UpdateLocationCommands command)
        {
            await _mediator.Send(command);
            return Ok("Lokasyon successfully updated");
        }
    }
}
