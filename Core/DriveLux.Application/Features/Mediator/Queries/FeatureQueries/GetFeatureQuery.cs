using MediatR;
using DriveLux.Application.Features.Mediator.Results.FeatureResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Queries.FeatureQueries
{
    public class GetFeatureQuery : IRequest<List<GetFeatureQueryResults>> 
    {
        public int FeaturesID { get; set; }
        public string Name { get; set; }

    }
}
