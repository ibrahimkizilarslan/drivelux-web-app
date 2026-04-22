using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Results.CarDescriptionResults
{
    public class GetCarDescriptionQueryResults
    {
        public int CarDescriptionID { get; set; }
        public int CarID { get; set; }
        public string Details { get; set; }
    }
}
