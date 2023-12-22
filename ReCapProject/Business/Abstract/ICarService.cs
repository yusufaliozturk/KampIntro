﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public interface ICarService
{

    IDataResult<List<Car>> GetAll();
    IDataResult<List<Car>> GetAllByBrandID(int id);
    IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);
    IDataResult<List<CarDetailDto>> GetCarDetails();
    IDataResult<Car> GetById(int CarID);
    IResult Update(Car car);
    IResult Add(Car car);
}
