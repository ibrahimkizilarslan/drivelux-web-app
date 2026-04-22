using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Interfaces.CarInterfaces
{
    public interface ICarRepository 
    {
        List<Car> GetCarsListWithBrands();
        List<Car> GetLast5CarsWithBrands();
    }
}
