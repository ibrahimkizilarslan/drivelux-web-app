using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Domain.Entities
{
    public class CarFeatures
    {
        public int CarFeaturesID { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
        public int FeaturesID { get; set; }
        public Features Features { get; set; }

        public bool Available { get; set; }
    }
}
