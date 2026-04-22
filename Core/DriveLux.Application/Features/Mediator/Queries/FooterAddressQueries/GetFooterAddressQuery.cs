using MediatR;
using DriveLux.Application.Features.Mediator.Results.FooterAddressResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Queries.FooterAddressQueries
{
     public class GetFooterAddressQuery : IRequest<List<GetFooterAddressQueryResults>>
    {

    }
}
