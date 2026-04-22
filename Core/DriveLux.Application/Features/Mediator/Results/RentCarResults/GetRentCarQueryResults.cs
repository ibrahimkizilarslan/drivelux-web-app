using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Results.RentCarResults
{
    public class GetRentCarQueryResults
    {
        public int CarID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; }

    }
}
