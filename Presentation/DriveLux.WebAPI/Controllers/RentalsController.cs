using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DriveLux.Application.Features.Mediator.Queries.RentCarQueries;

namespace DriveLux.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriveLuxsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DriveLuxsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetRentCarListByLocation(int locationID,bool available )
        {
            GetRentCarQuery getRentCarQuery = new GetRentCarQuery
            {
                LocationID = locationID,
                Available = available
            };
            var values = await _mediator.Send(getRentCarQuery);
            return Ok(values);
        }
    }
}
