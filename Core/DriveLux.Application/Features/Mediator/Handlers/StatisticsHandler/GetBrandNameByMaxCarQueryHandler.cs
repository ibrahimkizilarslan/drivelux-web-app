using MediatR;
using DriveLux.Application.Features.Mediator.Queries.StatisticsQueries;
using DriveLux.Application.Features.Mediator.Results.StatisticsResults;
using DriveLux.Application.Interfaces.StatisticsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.StatisticsHandler
{
    public class GetBrandNameByMaxCarQueryHandler : IRequestHandler<GetBrandNameByMaxCarQuery,GetBrandNameByMaxCarQueryResults>
    {
        private readonly IStatisticsRepository _repository;

        public GetBrandNameByMaxCarQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetBrandNameByMaxCarQueryResults> Handle(GetBrandNameByMaxCarQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetBrandNameByMaxCar();
            return new GetBrandNameByMaxCarQueryResults
            {
                BrandNameByMaxCar = value
            };
        }
    }
}
