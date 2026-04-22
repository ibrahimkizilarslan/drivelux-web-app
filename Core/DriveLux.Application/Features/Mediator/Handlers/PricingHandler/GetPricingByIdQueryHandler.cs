using MediatR;
using DriveLux.Application.Features.Mediator.Queries.PricingQueries;
using DriveLux.Application.Features.Mediator.Results.LocationResults;
using DriveLux.Application.Features.Mediator.Results.PricingResults;
using DriveLux.Application.Interfaces;
using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.PricingHandler
{
    public class GetPricingByIdQueryHandler : IRequestHandler<GetPricingByIdQuery, GetPricingByIdQueryResults>
    {

        private readonly IRepository<Pricing> _repository;

        public GetPricingByIdQueryHandler(IRepository<Pricing> repository)
        {
            _repository = repository;
        }

        public async Task<GetPricingByIdQueryResults> Handle(GetPricingByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetPricingByIdQueryResults
            {
                PricingID = values.PricingID,
                Name = values.Name,
            };
        }
    }
}
