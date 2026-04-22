using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DriveLux.Application.Features.Mediator.Commands.CommentCommands;
using DriveLux.Application.Features.Mediator.Commands.ReservationCommands;
using DriveLux.Application.Features.RepositoryPattern;
using DriveLux.Domain.Entities;

namespace DriveLux.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IGenericRepository<Comment> _repository;
        private readonly IMediator _mediator;

        public CommentsController(IGenericRepository<Comment> repository, IMediator mediator)
        {
            _repository = repository;
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult CommentList()
        {
            var values = _repository.GetAll();
            return Ok(values);
        }

        [HttpPost]

        public IActionResult CreateComment(Comment comment)
        {
            _repository.Create(comment);
            return Ok("Yorum successfully added");
        }


        [HttpDelete]

        public IActionResult RemoveComment(int id)
        {
            var value = _repository.GetById(id);
            _repository.Remove(value);
            return Ok("Yorum silindi");
        }

        [HttpPut]

        public IActionResult UpdateComment(Comment comment)
        {
            _repository.Update(comment);
            return Ok("Yorum successfully updated");
        }

        [HttpGet("{id}")]

        public IActionResult GetComment(int id)
        {
            var values = _repository.GetById(id);
            return Ok(values);
        }


        [HttpGet("CommentListByBlog")]

        public IActionResult CommentListByBlog(int id)
        {
            var values = _repository.GetCommentByBlogId(id);
            return Ok(values);
        }
        [HttpGet("CommentCountByBlog")]

        public IActionResult CommentCountByBlog(int id)
        {
            var values = _repository.GetCountCommentByBlog(id);
            return Ok(values);
        }

        [HttpPost("CreateCommentWithMediator")]

        public async Task<IActionResult> CreateCommentWithMediator(CreateCommentCommand command)
        {
            await _mediator.Send(command);
            return Ok("Yorum eklendi");
        }
    }
}
