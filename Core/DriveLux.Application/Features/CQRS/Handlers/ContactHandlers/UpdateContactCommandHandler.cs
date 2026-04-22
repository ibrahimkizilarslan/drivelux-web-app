using DriveLux.Application.Features.CQRS.Commands.ContactCommands;
using DriveLux.Application.Interfaces;
using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class UpdateContactCommandHandler
    {

        private readonly IRepository<Contact> _repository;

        public UpdateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateContactCommand command)
        {
            var values = await _repository.GetByIdAsync(command.ContactID);
            values.Name = command.Name;
            values.SendDate = command.SendDate;
            values.Email = command.Email;
            values.Message = command.Message;
            values.Subject = command.Subject;
            await _repository.UpdateAsync(values);

        }
    }
}
