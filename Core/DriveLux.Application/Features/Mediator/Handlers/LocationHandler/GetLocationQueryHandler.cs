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
    public class GetLocationQueryHandler : IRequestHandler<GetLocationQuery, List<GetLocationQueryResults>>
    {

        private readonly IRepository<Location> _repository;

        public GetLocationQueryHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLocationQueryResults>> Handle(GetLocationQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetLocationQueryResults
            {
               LocationID = x.LocationID,
               Name = x.Name,
            }).ToList();

        }
    }
}
