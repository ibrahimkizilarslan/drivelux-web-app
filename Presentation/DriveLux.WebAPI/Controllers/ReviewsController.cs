using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DriveLux.Application.Features.Mediator.Commands.ReviewCommands;
using DriveLux.Application.Features.Mediator.Queries.LocationQueries;
using DriveLux.Application.Features.Mediator.Queries.ReviewQueries;
using DriveLux.Application.Validators.ReviewValidators;

namespace DriveLux.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReviewsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> ReviewListByCarId(int id)
        {
            var values = await _mediator.Send(new ReviewQueries(id));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateReview(CreateReviewCommand createReviewCommand)
        {
            CreateReviewValidator validator = new CreateReviewValidator();
            var validatonResults = validator.Validate(createReviewCommand);
            if(!validatonResults.IsValid)
            {
                return BadRequest(validatonResults.Errors);
            }

            await _mediator.Send(createReviewCommand);
            return Ok("Successfully created");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateReview(UpdateReviewCommand updateReviewCommand)
        {
            await _mediator.Send(updateReviewCommand);
            return Ok("Successfully updated");
        }
    }
}
