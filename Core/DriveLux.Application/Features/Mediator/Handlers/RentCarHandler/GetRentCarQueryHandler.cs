using MediatR;
using DriveLux.Application.Features.Mediator.Queries.PricingQueries;
using DriveLux.Application.Features.Mediator.Queries.RentCarQueries;
using DriveLux.Application.Features.Mediator.Results.PricingResults;
using DriveLux.Application.Features.Mediator.Results.RentCarResults;
using DriveLux.Application.Interfaces;
using DriveLux.Application.Interfaces.RentCarInterfaces;
using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.RentCarHandler
{
    public class GetRentCarQueryHandler : IRequestHandler<GetRentCarQuery, List<GetRentCarQueryResults>>
    {
        private readonly IRentCarRepository _repository;


        public GetRentCarQueryHandler(IRentCarRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetRentCarQueryResults>> Handle(GetRentCarQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByFilterAsync(x => x.LocationID == request.LocationID && x.Available == true);
            var results =  values.Select(x => new GetRentCarQueryResults
            {
                CarID = x.CarID,
                Brand = x.Car.Brand.Name, 
                Model = x.Car.Model,
                CoverImageUrl = x.Car.CoverImageUrl,
            }).ToList();
            return results;
        }
    }
}