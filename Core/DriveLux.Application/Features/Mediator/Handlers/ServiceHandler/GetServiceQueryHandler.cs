using MediatR;
using DriveLux.Application.Features.Mediator.Queries.ServiceQueries;
using DriveLux.Application.Features.Mediator.Results.PricingResults;
using DriveLux.Application.Features.Mediator.Results.ServiceResults;
using DriveLux.Application.Interfaces;
using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.ServiceHandler
{
    public class GetServiceQueryHandler : IRequestHandler<GetServiceQuery, List<GetServiceQueryResults>>
    {

        private readonly IRepository<Service> _repository;

        public GetServiceQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetServiceQueryResults>> Handle(GetServiceQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetServiceQueryResults
            {
                ServiceID = x.ServiceID,
                Description = x.Description,
                Title = x.Title,
                IconUrl = x.IconUrl,
            }).ToList();
        }
    }
}
