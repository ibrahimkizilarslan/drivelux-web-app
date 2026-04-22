using MediatR;
using DriveLux.Application.Features.Mediator.Results.TestimonialResults;

namespace DriveLux.Application.Features.Mediator.Queries.TestimonialQueries
{
    public class GetTestimonialByIdQuery : IRequest<GetTestimonialByIdQueryResults>
    {
        public int Id { get; set; }

        public GetTestimonialByIdQuery(int id)
        {
            Id = id;
        }
    }
}