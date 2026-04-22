using MediatR;
using DriveLux.Application.Features.Mediator.Results.TagCloudResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Queries.TagCloudQueries
{
    public class GetTagCloudByBlogIdQuery : IRequest<List<GetTagCloudByBlogIdQueryResults>>
    {
        public int Id { get; set; }

        public GetTagCloudByBlogIdQuery(int id)
        {
            Id = id;
        }
    }
}
