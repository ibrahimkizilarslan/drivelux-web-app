using MediatR;
using DriveLux.Application.Features.Mediator.Results.TestimonialResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Queries.TestimonialQueries
{
    public class GetTestimonialQuery : IRequest<List<GetTestimonialQueryResults>>
    {
        public int TestimonialID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Comment { get; set; }
    }
}
