using MediatR;
using DriveLux.Application.Features.Mediator.Results.ReviewResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Queries.ReviewQueries
{
    public class ReviewQueries : IRequest<List<GetReviewByCarIdQueryResults>>
    {
        public int Id { get; set; }

        public ReviewQueries(int id)
        {
            Id = id;
        }
    }
}
