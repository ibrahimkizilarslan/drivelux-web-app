using MediatR;
using DriveLux.Application.Features.Mediator.Results.PricingResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Queries.PricingQueries
{
    public class GetPricingByIdQuery : IRequest<GetPricingByIdQueryResults>
    {
        public int Id { get; set; }

        public GetPricingByIdQuery(int id)
        {
            Id = id;
        }
    }
}
