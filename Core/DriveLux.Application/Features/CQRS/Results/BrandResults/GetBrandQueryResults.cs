using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.CQRS.Results.BrandResults
{
    public class GetBrandQueryResults
    {
        public int BrandID { get; set; }
        public string Name { get; set; }
    }
}
