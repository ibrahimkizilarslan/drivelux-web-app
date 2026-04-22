using MediatR;
using DriveLux.Application.Features.Mediator.Results.CarPricingResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Queries.CarPricingQueries
{
    public class GetCarPricingWithCarQuery : IRequest<List<GetCarPricingWithCarQueryResults>>
    {
        public int CarPricingID { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public decimal Amount { get; set; }

        public string CoverImageUrl { get; set; }

    }
}
