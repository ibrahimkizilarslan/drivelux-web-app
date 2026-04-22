using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Interfaces.CarFeatureInterfaces
{
    public interface ICarFeatureRepository
    {
        List<CarFeatures> GetCarFeaturesByCarId(int carId);
        void ChangeCarFeatureAvailableToFalse(int carId);
        void ChangeCarFeatureAvailableToTrue(int carId);
        void CreateCarFeatureByCar(CarFeatures carFeatures);
    }
}
