using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.DTO.TagCloudDTOs
{
    public class GetByBlogIdTagCloudDTO
    {
        public int TagCloudID { get; set; }
        public int BlogID { get; set; }
        public string Title { get; set; }
    }
}
