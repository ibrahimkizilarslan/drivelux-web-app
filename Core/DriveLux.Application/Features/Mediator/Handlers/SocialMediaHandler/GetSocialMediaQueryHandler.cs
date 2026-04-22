using MediatR;
using DriveLux.Application.Features.Mediator.Queries.SocialMediaQueries;
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
    public class GetSocialMediaQueryHandler : IRequestHandler<GetSocialMediaQuery, List<GetSocialMediaQueryResults>>
    {
        private readonly IRepository<SocialMedia> _repository;

        public GetSocialMediaQueryHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetSocialMediaQueryResults>> Handle(GetSocialMediaQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetSocialMediaQueryResults
            { 
             SocialMediaID = x.SocialMediaID,
             Icon = x.Icon,
             Name = x.Name,
             Url = x.Url,
            }).ToList();
        }
    }
}
