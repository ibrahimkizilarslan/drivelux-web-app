using MediatR;
using DriveLux.Application.Features.Mediator.Results.CarPricingResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Queries.CarPricingQueries
{
    public class GetCarPricingWithTimePeriodQuery : IRequest<List<GetCarPricingWithTimePeriodQueryResults>>
    {

    }
}
