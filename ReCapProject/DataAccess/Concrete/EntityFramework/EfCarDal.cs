using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentalContext>, ICarDal
    {
        //public List<CarDetailDto> GetCarDetails();
        //{
        //    using (RentalContext context = new RentalContext())
        //    {
        //        var result = from c in context.cars
        //                     join b in context.brands
        //                     on c.BrandId equals b.BrandID
        //                     select new CarDetailDto
        //                     {
        //                         CarID = c.CarID, BrandName = b.BrandName, 
        //                         CarName = c.CarName, ColorID = c.ColorID, 
        //                         ModelYear = c.ModelYear, DailyPrice = c.DailyPrice
        //                     };

        //    }
        //}

        public List<CarDetailDto> GetCarDetails()
        {
            using (RentalContext context = new RentalContext())
            {
                var result = from car in context.cars
                             join b in context.brands
                             on car.BrandId equals b.BrandID
                             join c in context.colors
                             on car.ColorID equals c.ColorID
                             select new CarDetailDto
                             {
                                 CarID = car.CarID,
                                 BrandID = b.BrandID,
                                 ColorID = c.ColorID,
                                 CarName = car.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = c.ColorName,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,

                                 ImagePath = (from ci in context.carImages where ci.CarID == car.CarID select ci.ImagePath).FirstOrDefault()
                             };

                return result.ToList();
            }
        }
    }
}