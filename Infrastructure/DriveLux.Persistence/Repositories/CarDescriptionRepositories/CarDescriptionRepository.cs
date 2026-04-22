using DriveLux.Application.Interfaces.CarDescriptionInterfaces;
using DriveLux.Domain.Entities;
using DriveLux.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Persistence.Repositories.CarDescriptionRepositories
{
    public class CarDescriptionRepository : ICarDescriptionRepository
    {
        private readonly DriveLuxContext _context;

        public CarDescriptionRepository(DriveLuxContext context)
        {
            _context = context;
        }

        public CarDescription GetCarDescription(int carId)
        {
            var values = _context.CarDescriptions.Where(x => x.CarID == carId).FirstOrDefault();
            return values;
        }
    }
}
