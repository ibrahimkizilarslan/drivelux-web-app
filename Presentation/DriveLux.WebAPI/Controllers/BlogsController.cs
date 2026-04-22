using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DriveLux.Application.Features.Mediator.Commands.BlogCommands;
using DriveLux.Application.Features.Mediator.Queries.BlogQueries;

namespace DriveLux.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IMediator _mediator;  // Registering handlers via MediatR avoids manual injection.

        public BlogsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> BlogList()
        {
            // Send metodu ilgili handlera istek yapar.
            var values = await _mediator.Send(new GetBlogQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetBlog(int id)
        {
            var value = await _mediator.Send(new GetBlogByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]

        public async Task<IActionResult> CreateBlog(CreateBlogCommands command)
        {
            await _mediator.Send(command);
            return Ok("Blog eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveBlog(int id)
        {
            await _mediator.Send(new RemoveBlogCommands(id));
            return Ok("Blog successfully deleted");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBlog(UpdateBlogCommands command)
        {
            await _mediator.Send(command);
            return Ok("Blog successfully updated");
        }

        [HttpGet("GetLast3BlogsWithAuthorsList")]
        public async Task<IActionResult> GetLast3BlogsWithAuthorsList()
        {
            var values = await _mediator.Send(new GetLast3BlogsWithAuthorsQuery());
            return Ok(values);
        }

        [HttpGet("GetAllBlogsWithAuthorsList")]

        public async Task<IActionResult> GetAllBlogsWithAuthorsList()
        {
            var values = await _mediator.Send(new GetAllBlogsWithAuthorQuery());
            return Ok(values);
        }


        [HttpGet("GetBlogByAuthorId")]

        public async Task<IActionResult> GetBlogByAuthorId(int id)
        {
            var values = await _mediator.Send(new GetBlogByAuthorIdQuery(id));
            return Ok(values);
        }
    }
}
