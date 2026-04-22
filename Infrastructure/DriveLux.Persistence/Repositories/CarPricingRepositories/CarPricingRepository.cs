using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using DriveLux.Application.Interfaces.CarPricingInterfaces;
using DriveLux.Application.ViewModels;
using DriveLux.Domain.Entities;
using DriveLux.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DriveLux.Persistence.Repositories.CarPricingRepositories
{
    public class CarPricingRepository : ICarPricingRepository
    {
        private readonly DriveLuxContext _context;

        public CarPricingRepository(DriveLuxContext context)
        {
            _context = context;
        }

        public List<CarPricingViewModel> GetCarsPricingWithTimePeriod1()
        {
            List<CarPricingViewModel> values = new List<CarPricingViewModel>();
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "Select * From (Select Model,Name,CoverImageUrl,PricingID,Amount From CarPricings Inner Join Cars On Cars.CarID=CarPricings.CarId Inner Join Brands On Brands.BrandID=Cars.BrandID) As SourceTable Pivot (Sum(Amount) For PricingID In ([1],[2],[3])) as PivotTable;";
                command.CommandType = System.Data.CommandType.Text;
                _context.Database.OpenConnection();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CarPricingViewModel carPricingViewModel = new CarPricingViewModel()
                        {
                            Brand = reader["Name"].ToString(),
                            Model = reader["Model"].ToString(),
                            CoverImageUrl = reader["CoverImageUrl"].ToString(),
                            Amounts = new List<decimal>
                            {
                                Convert.ToDecimal(reader["1"]),
                                Convert.ToDecimal(reader["2"]),
                                Convert.ToDecimal(reader["3"])
                            }

                        };
                        values.Add(carPricingViewModel);
                    }
                } 
                _context.Database.CloseConnection();
                return values;
            }
        }        
        public List<CarPricing> GetCarsPricingsWithCars()
        {
            var values = _context.CarPricings.Include(x => x.Car).ThenInclude(y => y.Brand).Include(x => x.Pricing).Where(z => z.PricingID == 2).ToList();
            return values;
        }

        public List<CarPricing> GetCarsPricingsWithTimePeriod()
        {
            throw new NotImplementedException();
        }
    }
}


