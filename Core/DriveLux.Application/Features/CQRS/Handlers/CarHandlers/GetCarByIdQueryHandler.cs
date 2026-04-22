using DriveLux.Application.Features.CQRS.Queries.CarQueries;
using DriveLux.Application.Features.CQRS.Results.CarResults;
using DriveLux.Application.Interfaces;
using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarByIdQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task<GetCarByIdQueryResults> Handle(GetCarByIdQuery results)
        {
            var values = await _repository.GetByIdAsync(results.Id);
            return new GetCarByIdQueryResults
            {
                BrandID = values.BrandID,
                BigImageUrl = values.BigImageUrl,
                CoverImageUrl = values.CoverImageUrl,
                Fuel = values.Fuel,
                CarID = values.CarID,
                Transmission = values.Transmission,
                Seat = values.Seat,
                Model = values.Model,
                Km = values.Km,
                Luggage = values.Luggage,
                
            };
        }
    }
}
