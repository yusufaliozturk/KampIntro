using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //carTest();
            brandTest();
            //RentalTest();
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            foreach (var rental in rentalManager.GetAll())
            {
                Console.WriteLine("Alış Tarihi : " + rental.RentDate);
                Console.WriteLine("Verdiği Tarih :" + rental.ReturnDate + "\n");

            }
        }

        private static void brandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandID + " - " + brand.BrandName);
            }
        }

        private static void carTest()
        {
            CarManager carManager = new(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success ==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.BrandName + "\n");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            //foreach (var car in carManager.GetCarDetails().Data)
            //{
            //    Console.WriteLine("Araba Marka: " + car.CarName);
            //    //Console.WriteLine("fiyat: " + car.DailyPrice);
            //    //Console.WriteLine("fiyat: " + car.Description);
            //    Console.WriteLine("Rengi: " + car.ColorName);
            //    Console.WriteLine("Marka Adı: " + car.BrandName + "\n");
            //}
        }
    }
}