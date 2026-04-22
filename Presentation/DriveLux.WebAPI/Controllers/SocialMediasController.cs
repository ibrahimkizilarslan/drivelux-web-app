using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DriveLux.Application.Features.Mediator.Commands.SocialMediaCommands;
using DriveLux.Application.Features.Mediator.Queries.SocialMediaQueries;

namespace DriveLux.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController : ControllerBase
    {
        private readonly IMediator _mediator;  // Registering handlers via MediatR avoids manual injection.

        public SocialMediasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> SocialMediaList()
        {
            // Send metodu ilgili handlera istek yapar.
            var values = await _mediator.Send(new GetSocialMediaQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetSocialMedia(int id)
        {
            var value = await _mediator.Send(new GetSocialMediaByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]

        public async Task<IActionResult> CreateSocialMedia(CreateSocialMediaCommands command)
        {
            await _mediator.Send(command);
            return Ok("Sosyal Medya eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveSocialMedia(int id)
        {
            await _mediator.Send(new RemoveSocialMediaCommands(id));
            return Ok("Sosyal Medya successfully deleted");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSocialMedia(UpdateSocialMediaCommands command)
        {
            await _mediator.Send(command);
            return Ok("Sosyal Medya successfully updated");
        }
    }
}
