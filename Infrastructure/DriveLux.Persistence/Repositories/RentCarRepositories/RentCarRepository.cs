using Microsoft.EntityFrameworkCore;
using DriveLux.Application.Interfaces.RentCarInterfaces;
using DriveLux.Domain.Entities;
using DriveLux.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Persistence.Repositories.RentCarRepositories
{
    public class RentCarRepository : IRentCarRepository
    {

        private readonly DriveLuxContext _context;

        public RentCarRepository(DriveLuxContext context)
        {
            _context = context;
        }

        public async Task<List<RentCar>> GetByFilterAsync(Expression<Func<RentCar, bool>> filter)
        {
            var values = await _context.RentCars.Where(filter).Include(x=>x.Car).ThenInclude(y => y.Brand).ToListAsync();
            return values;
        }
    }
}
