using MediatR;
using DriveLux.Application.Features.Mediator.Commands.FooterAddressCommand;
using DriveLux.Application.Interfaces;
using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.FooterAddressHandler
{
    public class UpdateFooterAddressCommandHandler : IRequestHandler<UpdateFooterAddressCommand>
    {
        private readonly IRepository<FooterAddress> _repository;

        public UpdateFooterAddressCommandHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.FooterAddressID);
            values.Phone = request.Phone;
            values.Address = request.Address;
            values.Email = request.Email;
            values.FooterAddressID = request.FooterAddressID;
            values.Description = request.Description;
            await _repository.UpdateAsync(values);
        }
    }
}
