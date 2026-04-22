using MediatR;
using DriveLux.Application.Features.Mediator.Queries.TestimonialQueries;
using DriveLux.Application.Features.Mediator.Results.SocialMediaResults;
using DriveLux.Application.Features.Mediator.Results.TestimonialResults;
using DriveLux.Application.Interfaces;
using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.TestimonialHandler
{
    public class GetTestimonialByIdQueryHandler : IRequestHandler<GetTestimonialByIdQuery, GetTestimonialByIdQueryResults>
    {
        private readonly IRepository<Testimonial> _repository;

        public GetTestimonialByIdQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task<GetTestimonialByIdQueryResults> Handle(GetTestimonialByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetTestimonialByIdQueryResults
            {
                TestimonialID = values.TestimonialID,
                Name = values.Name,
                Title = values.Title,
                ImageUrl = values.ImageUrl,
                Comment = values.Comment
            };

        }
    }
}
