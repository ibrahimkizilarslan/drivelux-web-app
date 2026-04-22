using MediatR;
using DriveLux.Application.Features.Mediator.Commands.ReviewCommands;
using DriveLux.Application.Interfaces;
using DriveLux.Application.Interfaces.ReviewInterfaces;
using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.ReviewHandler
{
    public class CreateReviewHandler : IRequestHandler<CreateReviewCommand>
    {
        private readonly IRepository<Review> _repository;

        public CreateReviewHandler(IRepository<Review> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateReviewCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Review
            {
                CustomerImage = request.CustomerImage,
                CarID = request.CarID,
                Comment = request.Comment,
                CustomerName = request.CustomerName,
                RatingValue = request.RatingValue,
                ReviewDate = DateTime.Parse(DateTime.Now.ToShortDateString())
            });
        }
    }
}
