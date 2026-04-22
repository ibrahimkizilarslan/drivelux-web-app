using MediatR;
using DriveLux.Application.Features.Mediator.Queries.CarPricingQueries;
using DriveLux.Application.Features.Mediator.Results.CarPricingResults;
using DriveLux.Application.Interfaces.CarInterfaces;
using DriveLux.Application.Interfaces.CarPricingInterfaces;
using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.CarPricingHandler
{
    public class GetCarPricingWithTimePeriodQueryHandler : IRequestHandler<GetCarPricingWithTimePeriodQuery, List<GetCarPricingWithTimePeriodQueryResults>>
    {
        private readonly ICarPricingRepository _repository;

        public GetCarPricingWithTimePeriodQueryHandler(ICarPricingRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarPricingWithTimePeriodQueryResults>> Handle(GetCarPricingWithTimePeriodQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetCarsPricingWithTimePeriod1();
            return values.Select(x=> new GetCarPricingWithTimePeriodQueryResults
            {
               Brand = x.Brand,
               Model = x.Model,
               CoverImageUrl = x.CoverImageUrl,
               DailyAmount = x.Amounts[0],
               WeeklyAmount = x.Amounts[1],
               MonthlyAmount = x.Amounts[2],              
            }).ToList();
        }
    }
}
