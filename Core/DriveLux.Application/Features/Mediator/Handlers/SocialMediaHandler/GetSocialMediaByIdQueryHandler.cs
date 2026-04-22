using MediatR;
using DriveLux.Application.Features.Mediator.Queries.SocialMediaQueries;
using DriveLux.Application.Features.Mediator.Results.ServiceResults;
using DriveLux.Application.Features.Mediator.Results.SocialMediaResults;
using DriveLux.Application.Interfaces;
using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.SocialMediaHandler
{
    public class GetSocialMediaByIdQueryHandler : IRequestHandler<GetSocialMediaByIdQuery, GetSocialMediaByIdQueryResults>
    {

        private readonly IRepository<SocialMedia> _repository;

        public GetSocialMediaByIdQueryHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task<GetSocialMediaByIdQueryResults> Handle(GetSocialMediaByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetSocialMediaByIdQueryResults
            {
               SocialMediaID = values.SocialMediaID,
               Icon = values.Icon,
               Url = values.Url,
               Name = values.Name,
            };
        }
    }
}
