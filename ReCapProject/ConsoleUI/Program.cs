using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

public class Program
{
    static void Main(string[] args)
    {

        CarManager carManager = new CarManager(new InMemoryCarDal());

        foreach (var car in carManager.GetAll())
        {
            Console.WriteLine(car.CarId + "--" + car.ModelYear + "--" + car.DailyPrice);
        }

        carManager.Add(new Car
        {
            BrandId = 8,
            CarId = 7,
            ColorId = 6,
            DailyPrice = 5000,
            ModelYear = 2015,
            Description = "Aciklama"
        });

        Console.WriteLine("/////////////////////////");

        foreach (var car in carManager.GetAll())
        {
            Console.WriteLine(car.CarId + "--" + car.ModelYear + "--" + car.DailyPrice);
        }

        carManager.Remove(new Car { CarId = 5 });

        Console.WriteLine("/////////////////////////");

        foreach (var car in carManager.GetAll())
        {
            Console.WriteLine(car.CarId + "--" + car.ModelYear + "--" + car.DailyPrice);
        }
    }
}
