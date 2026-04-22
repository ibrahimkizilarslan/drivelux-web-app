using MediatR;
using DriveLux.Application.Features.Mediator.Queries.FooterAddressQueries;
using DriveLux.Application.Features.Mediator.Results.FeatureResults;
using DriveLux.Application.Features.Mediator.Results.FooterAddressResults;
using DriveLux.Application.Interfaces;
using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.FooterAddressHandler
{
    public class GetFooterAddressByIdQueryHandler : IRequestHandler<GetFooterAddressByIdQuery, GetFooterAddressByIdQueryResults>
    {

        private readonly IRepository<FooterAddress> _repository;

        public GetFooterAddressByIdQueryHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task<GetFooterAddressByIdQueryResults> Handle(GetFooterAddressByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetFooterAddressByIdQueryResults
            {
                Address = value.Address,
                Description = value.Description,
                Email = value.Email,
                FooterAddressID = value.FooterAddressID,
                Phone = value.Phone,
            };
        }

    }
}
