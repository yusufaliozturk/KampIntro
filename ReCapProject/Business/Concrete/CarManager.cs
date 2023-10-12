using Business.Abstract;
using DataAccess.Abstract; // Import the correct namespace
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetById(int CarId)
        {
            return _carDal.GetById(CarId);
        }

        public void Remove(Car car)
        {
            _carDal.Remove(car);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
