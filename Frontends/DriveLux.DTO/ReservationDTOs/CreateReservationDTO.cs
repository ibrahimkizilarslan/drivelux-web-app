using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.DTO.ReservationDTOs
{
    public class CreateReservationDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public int PickUpLocationID { get; set; }
        public int DropOffLocationID { get; set; }
        public string Email { get; set; }
        public int CarID { get; set; }
        public int Age { get; set; }
        public int DriverLicenseYear { get; set; }
        public string Description { get; set; }
    }
}
