using MediatR;
using DriveLux.Application.Features.Mediator.Commands.ReviewCommands;
using DriveLux.Application.Interfaces;
using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.ReviewHandler
{
    public class UpdateReviewHandler : IRequestHandler<UpdateReviewCommand>
    {
        private readonly IRepository<Review> _repository;

        public UpdateReviewHandler(IRepository<Review> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateReviewCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.ReviewID);
            values.CustomerName = request.CustomerName;
            values.ReviewDate = request.ReviewDate;
            values.CarID = request.CarID;
            values.Comment = request.Comment;
            values.RatingValue = request.RatingValue;
            await _repository.UpdateAsync(values);
        }
    }
}
