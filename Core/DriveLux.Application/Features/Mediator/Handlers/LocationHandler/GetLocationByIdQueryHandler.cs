using MediatR;
using DriveLux.Application.Features.Mediator.Queries.LocationQueries;
using DriveLux.Application.Features.Mediator.Results.FeatureResults;
using DriveLux.Application.Features.Mediator.Results.LocationResults;
using DriveLux.Application.Interfaces;
using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.LocationHandler
{
    public class GetLocationByIdQueryHandler : IRequestHandler<GetLocationByIdQuery, GetLocationByIdQueryResults>
    {

        private readonly IRepository<Location> _repository;

        public GetLocationByIdQueryHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task<GetLocationByIdQueryResults> Handle(GetLocationByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetLocationByIdQueryResults
            {
                LocationID = values.LocationID,
                Name = values.Name,
            };
        }
    }
}
