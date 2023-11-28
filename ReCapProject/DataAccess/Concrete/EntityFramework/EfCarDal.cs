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
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentalContext context = new RentalContext())
            {
                var result = from c in context.cars
                             join b in context.brands
                             on c.BrandId equals b.BrandID
                             select new CarDetailDto
                             {
                                 CarID = c.CarID,
                                 BrandName = b.BrandName,
                                 CarName = c.CarName,
                                 ColorID = c.ColorID,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}