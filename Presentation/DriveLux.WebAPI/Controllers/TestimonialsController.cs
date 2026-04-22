using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DriveLux.Application.Features.Mediator.Commands.TestimonialCommands;
using DriveLux.Application.Features.Mediator.Queries.TestimonialQueries;

namespace DriveLux.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly IMediator _mediator;  // Registering handlers via MediatR avoids manual injection.

        public TestimonialsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> TestimonialList()
        {
            // Send metodu ilgili handlera istek yapar.
            var values = await _mediator.Send(new GetTestimonialQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetTestimonial(int id)
        {
            var value = await _mediator.Send(new GetTestimonialByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]

        public async Task<IActionResult> CreateTestimonial(CreateTestimonialCommands command)
        {
            await _mediator.Send(command);
            return Ok("Referans eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveTestimonial(int id)
        {
            await _mediator.Send(new RemoveTestimonialCommands(id));
            return Ok("Referans successfully deleted");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialCommands command)
        {
            await _mediator.Send(command);
            return Ok("Referans successfully updated");
        }
    }
}
