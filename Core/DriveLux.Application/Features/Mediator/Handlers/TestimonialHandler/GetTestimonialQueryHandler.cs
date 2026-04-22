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
    public class GetTestimonialQueryHandler : IRequestHandler<GetTestimonialQuery, List<GetTestimonialQueryResults>>
    {
        private readonly IRepository<Testimonial> _repository;

        public GetTestimonialQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTestimonialQueryResults>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetTestimonialQueryResults
            {
                TestimonialID = x.TestimonialID,
                Name = x.Name,
                Title = x.Title,
                ImageUrl = x.ImageUrl,
                Comment = x.Comment
            }).ToList();
        }
    }
}
