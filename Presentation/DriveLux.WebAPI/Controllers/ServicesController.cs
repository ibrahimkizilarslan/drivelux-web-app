using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DriveLux.Application.Features.Mediator.Commands.ServiceCommands;
using DriveLux.Application.Features.Mediator.Queries.ServiceQueries;

namespace DriveLux.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IMediator _mediator;  // Registering handlers via MediatR avoids manual injection.

        public ServicesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ServiceList()
        {
            // Send metodu ilgili handlera istek yapar.
            var values = await _mediator.Send(new GetServiceQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetService(int id)
        {
            var value = await _mediator.Send(new GetServiceByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]

        public async Task<IActionResult> CreateService(CreateServiceCommands command)
        {
            await _mediator.Send(command);
            return Ok("Service eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveService(int id)
        {
            await _mediator.Send(new RemoveServiceCommands(id));
            return Ok("Service successfully deleted");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceCommands command)
        {
            await _mediator.Send(command);
            return Ok("Service successfully updated");
        }
    }
}
