using MediatR;
using DriveLux.Application.Features.Mediator.Commands.SocialMediaCommands;
using DriveLux.Application.Features.Mediator.Commands.TestimonialCommands;
using DriveLux.Application.Interfaces;
using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.TestimonialHandler
{
    public class CreateTestimonialCommandHandler : IRequestHandler<CreateTestimonialCommands>
    {
        private readonly IRepository<Testimonial> _repository;

        public CreateTestimonialCommandHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateTestimonialCommands request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Testimonial
            {
                Name = request.Name,
                Title = request.Title,
                ImageUrl = request.ImageUrl,
                Comment = request.Comment
            });

        }
    }
}
