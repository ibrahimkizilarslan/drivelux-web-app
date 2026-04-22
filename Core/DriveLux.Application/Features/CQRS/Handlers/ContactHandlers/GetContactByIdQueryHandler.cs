using DriveLux.Application.Features.CQRS.Queries.ContactQueries;
using DriveLux.Application.Features.CQRS.Results.ContactResults;
using DriveLux.Application.Interfaces;
using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class GetContactByIdQueryHandler
    {
        private readonly IRepository<Contact> _repository;

        public GetContactByIdQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task<GetContactByIdQueryResults> Handle(GetContactByIdQuery results)
        {
            var values = await _repository.GetByIdAsync(results.Id);
            return new GetContactByIdQueryResults
            {
                ContactID = values.ContactID,
                Name = values.Name,
                Email = values.Email,
                Subject = values.Subject,
                SendDate = values.SendDate,
                Message = values.Message,
            };
        }
    }
}
