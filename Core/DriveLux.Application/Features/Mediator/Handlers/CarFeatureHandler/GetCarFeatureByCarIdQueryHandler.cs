using MediatR;
using DriveLux.Application.Features.Mediator.Queries.CarFeatureQueries;
using DriveLux.Application.Features.Mediator.Results.BlogResults;
using DriveLux.Application.Features.Mediator.Results.CarFeatureResult;
using DriveLux.Application.Interfaces;
using DriveLux.Application.Interfaces.CarFeatureInterfaces;
using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.CarFeatureHandler
{
    public class GetCarFeatureByCarIdQueryHandler : IRequestHandler<GetCarFeatureByCarIdQuery, List<GetCarFeatureByCarIdQueryResults>>
    {
        private readonly ICarFeatureRepository _repository;

        public GetCarFeatureByCarIdQueryHandler(ICarFeatureRepository repository)
        {
            _repository = repository;
        }


        public async Task<List<GetCarFeatureByCarIdQueryResults>> Handle(GetCarFeatureByCarIdQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetCarFeaturesByCarId(request.Id);
            return values.Select(x => new GetCarFeatureByCarIdQueryResults
            {
                Available = x.Available,
                CarFeaturesID = x.CarFeaturesID,
                FeaturesID = x.FeaturesID,
                FeaturesName = x.Features.Name,              
            }).ToList();
        }
    }
}
