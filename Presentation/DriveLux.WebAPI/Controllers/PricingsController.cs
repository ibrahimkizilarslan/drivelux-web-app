using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DriveLux.Application.Features.Mediator.Commands.PricingCommands;
using DriveLux.Application.Features.Mediator.Queries.PricingQueries;

namespace DriveLux.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PricingsController : ControllerBase
    {
        private readonly IMediator _mediator;  // Registering handlers via MediatR avoids manual injection.

        public PricingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> PricingList()
        {
            // Send metodu ilgili handlera istek yapar.
            var values = await _mediator.Send(new GetPricingQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetPricing(int id)
        {
            var value = await _mediator.Send(new GetPricingByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]

        public async Task<IActionResult> CreatePricing(CreatePricingCommands command)
        {
            await _mediator.Send(command);
            return Ok("Pricing eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemovePricing(int id)
        {
            await _mediator.Send(new RemovePricingCommands(id));
            return Ok("Pricing successfully deleted");
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePricing(UpdatePricingCommands command)
        {
            await _mediator.Send(command);
            return Ok("Pricing successfully updated");
        }
    }
}
