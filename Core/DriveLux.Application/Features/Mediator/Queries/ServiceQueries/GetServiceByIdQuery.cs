using MediatR;
using DriveLux.Application.Features.Mediator.Results.ServiceResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Queries.ServiceQueries
{
    public class GetServiceByIdQuery : IRequest<GetServiceByIdQueryResults>
    {
        public int Id { get; set; }

        public GetServiceByIdQuery(int id)
        {
            Id = id;
        }
    }
}
