using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DriveLux.Application.Features.Mediator.Commands.AuthorCommands;
using DriveLux.Application.Features.Mediator.Queries.AuthorQueries;

namespace DriveLux.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IMediator _mediator;  // Registering handlers via MediatR avoids manual injection.

        public AuthorsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> AuthorList()
        {
            // Send metodu ilgili handlera istek yapar.
            var values = await _mediator.Send(new GetAuthorQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetAuthor(int id)
        {
            var value = await _mediator.Send(new GetAuthorByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]

        public async Task<IActionResult> CreateAuthor(CreateAuthorCommands command)
        {
            await _mediator.Send(command);
            return Ok("Author eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveAuthor(int id)
        {
            await _mediator.Send(new RemoveAuthorCommands(id));
            return Ok("Author successfully deleted");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAuthor(UpdateAuthorCommands command)
        {
            await _mediator.Send(command);
            return Ok("Author successfully updated");
        }
    }
}
