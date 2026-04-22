using DriveLux.Application.ViewModels;
using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Interfaces.CarPricingInterfaces
{
    public interface ICarPricingRepository
    {
        List<CarPricing> GetCarsPricingsWithCars();
        List<CarPricing> GetCarsPricingsWithTimePeriod();

        List<CarPricingViewModel> GetCarsPricingWithTimePeriod1();
    }
}
