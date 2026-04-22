using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DriveLux.Application.Features.Mediator.Commands.TagCloudCommands;
using DriveLux.Application.Features.Mediator.Queries.TagCloudQueries;

namespace DriveLux.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagCloudsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TagCloudsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> TagCloudList()
        {
            // Send metodu ilgili handlera istek yapar.
            var values = await _mediator.Send(new GetTagCloudQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetTagCloud(int id)
        {
            var value = await _mediator.Send(new GetTagCloudByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]

        public async Task<IActionResult> CreateTagCloud(CreateTagCloudCommands command)
        {
            await _mediator.Send(command);
            return Ok("Tag Cloud eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveTagCloud(int id)
        {
            await _mediator.Send(new RemoveTagCloudCommands(id));
            return Ok("Tag Cloud successfully deleted");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTagCloud(UpdateTagCloudCommands command)
        {
            await _mediator.Send(command);
            return Ok("Tag Cloud successfully updated");
        }

        [HttpGet("GetTagCloudByBlogId")]
        public async Task<IActionResult> GetTagCloudByBlogId(int id)
        {
            var values = await _mediator.Send(new GetTagCloudByBlogIdQuery(id));
            return Ok(values);
        }
    }
}
