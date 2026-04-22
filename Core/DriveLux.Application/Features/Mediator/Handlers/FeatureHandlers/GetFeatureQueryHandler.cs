using MediatR;
using DriveLux.Application.Features.Mediator.Queries.FeatureQueries;
using DriveLux.Application.Features.Mediator.Results.FeatureResults;
using DriveLux.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.FeatureHandlers
{
    public class GetFeatureQueryHandler : IRequestHandler<GetFeatureQuery /* Request entry point */ , /* Returns as list */ List<GetFeatureQueryResults>>
    {

        private readonly IRepository<Domain.Entities.Features> _repository;

        public GetFeatureQueryHandler(IRepository<Domain.Entities.Features> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFeatureQueryResults>> Handle(GetFeatureQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetFeatureQueryResults
            {
                FeaturesID = x.FeaturesID,
                Name = x.Name,
            }).ToList();
        }
    }
}
