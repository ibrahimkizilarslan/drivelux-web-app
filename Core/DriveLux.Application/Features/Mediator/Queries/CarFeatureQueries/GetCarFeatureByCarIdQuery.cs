using MediatR;
using DriveLux.Application.Features.Mediator.Results.CarFeatureResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Queries.CarFeatureQueries
{
    public class GetCarFeatureByCarIdQuery : IRequest<List<GetCarFeatureByCarIdQueryResults>>
    {
        public int Id { get; set; }

        public GetCarFeatureByCarIdQuery(int id)
        {
            Id = id;
        }
    }
}
