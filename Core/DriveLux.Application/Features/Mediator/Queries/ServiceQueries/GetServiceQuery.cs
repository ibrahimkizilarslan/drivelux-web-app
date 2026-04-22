using MediatR;
using DriveLux.Application.Features.Mediator.Results.ServiceResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Queries.ServiceQueries
{
    public class GetServiceQuery : IRequest<List<GetServiceQueryResults>>
    {
        public int ServiceID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
    }
}
