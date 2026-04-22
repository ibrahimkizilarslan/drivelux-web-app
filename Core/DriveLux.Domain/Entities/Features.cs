using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Domain.Entities
{
    public class Features
    {
        public int FeaturesID { get; set; }
        public string Name { get; set; }
        public List<CarFeatures> CarFeatures { get; set; }
    }
}
