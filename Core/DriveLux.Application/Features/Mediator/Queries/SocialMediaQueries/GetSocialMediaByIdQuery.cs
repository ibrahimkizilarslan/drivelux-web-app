using MediatR;
using DriveLux.Application.Features.Mediator.Results.SocialMediaResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaByIdQuery : IRequest<GetSocialMediaByIdQueryResults>
    {
        public int Id { get; set; }

        public GetSocialMediaByIdQuery(int id)
        {
            Id = id;
        }
    }
}
