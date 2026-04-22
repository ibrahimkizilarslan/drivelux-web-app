using Microsoft.EntityFrameworkCore;
using DriveLux.Application.Interfaces.CarFeatureInterfaces;
using DriveLux.Domain.Entities;
using DriveLux.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Persistence.Repositories.CarFeatureRepositories
{
    public class CarFeatureRepository : ICarFeatureRepository
    {
        private readonly DriveLuxContext _context;

        public CarFeatureRepository(DriveLuxContext context)
        {
            _context = context;
        }

        public void ChangeCarFeatureAvailableToFalse(int carId)
        {
            var values = _context.CarFeatures.Where(x => x.CarFeaturesID == carId).FirstOrDefault();
            values.Available = false;
            _context.SaveChanges();
        }

        public void ChangeCarFeatureAvailableToTrue(int carId)
        {
            var values = _context.CarFeatures.Where(x => x.CarFeaturesID == carId).FirstOrDefault();
            values.Available = true;
            _context.SaveChanges();
        }

        public void CreateCarFeatureByCar(CarFeatures carFeatures)
        {
            _context.CarFeatures.Add(carFeatures);
            _context.SaveChanges();
        }

        public List<CarFeatures> GetCarFeaturesByCarId(int carId)
        {
            var values = _context.CarFeatures.Include(y=>y.Features).Where(x=>x.CarID == carId).ToList();
            return values;
        }
    }
}
