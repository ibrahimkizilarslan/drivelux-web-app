using Microsoft.EntityFrameworkCore;
using DriveLux.Application.Interfaces.CarInterfaces;
using DriveLux.Domain.Entities;
using DriveLux.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Persistence.Repositories.CarRepositories
{
    public class CarRepository : ICarRepository
    {

        private readonly DriveLuxContext _context;

        public CarRepository(DriveLuxContext context)
        {
            _context = context;
        }

        public List<Car> GetCarsListWithBrands()
        {
            var values = _context.Cars.Include(x => x.Brand).ToList();
            return values;
        }

        public List<Car> GetLast5CarsWithBrands()
        {
            var values = _context.Cars.Include(x => x.Brand).OrderByDescending(x => x.CarID).Take(5).ToList();
            return values;
        }
    }
}
