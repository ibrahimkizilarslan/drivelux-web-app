using MediatR;
using DriveLux.Application.Features.Mediator.Results.StatisticsResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Queries.StatisticsQueries
{
    public class GetCarCountByKmSmallerThen1000Query : IRequest<GetCarCountByKmSmallerThen1000QueryResults>
    {
    }
}
