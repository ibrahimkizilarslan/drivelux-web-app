using DriveLux.Application.Interfaces.ReviewInterfaces;
using DriveLux.Domain.Entities;
using DriveLux.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Persistence.Repositories.ReviewRepository
{
    public class ReviewRepository : IReviewRepository
    {

        private readonly DriveLuxContext _context;

        public ReviewRepository(DriveLuxContext context)
        {
            _context = context;
        }

        public List<Review> GetReviewsByCarId(int carID)
        {
            var values = _context.Reviews.Where(x=>x.CarID == carID).ToList();
            return values;
        }
    }
}
