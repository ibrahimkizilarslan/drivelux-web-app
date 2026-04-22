using MediatR;
using DriveLux.Application.Features.Mediator.Results.TagCloudResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Queries.TagCloudQueries
{
    public class GetTagCloudByIdQuery : IRequest<GetTagCloudByIdQueryResults>
    {
        public int Id { get; set; }

        public GetTagCloudByIdQuery(int id)
        {
            Id = id;
        }
    }
}
