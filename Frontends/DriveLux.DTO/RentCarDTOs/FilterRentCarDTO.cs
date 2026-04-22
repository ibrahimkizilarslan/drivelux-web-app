using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.DTO.RentCarDTOs
{
    public class FilterRentCarDTO
    {
        public int CarID { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string CoverImageUrl { get; set; }

    }
}
