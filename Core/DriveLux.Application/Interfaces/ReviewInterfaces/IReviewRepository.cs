using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Interfaces.ReviewInterfaces
{
    public interface IReviewRepository
    {
        public List<Review> GetReviewsByCarId(int carID);
    }
}
