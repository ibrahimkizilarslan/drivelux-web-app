using MediatR;
using DriveLux.Application.Features.CQRS.Results.AboutResults;
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
    public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResults>
    {
        private readonly IRepository<Service> _repository;

        public GetServiceByIdQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<GetServiceByIdQueryResults> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetServiceByIdQueryResults
            {
               ServiceID = values.ServiceID,
               Title = values.Title,
               Description = values.Description,
               IconUrl = values.IconUrl,
            };
        }
    }
}
