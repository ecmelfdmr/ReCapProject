using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal() 
        {
            _cars = new List<Car>
            {
                new Car {CarId=1, BrandId=5, ColorId=6, DailyPrice=140000, Description="Ford", ModelYear="2014"},
                new Car {CarId=2, BrandId=5, ColorId=7, DailyPrice=90000, Description="Honda", ModelYear="2015"},
                new Car {CarId=3, BrandId=5, ColorId=8, DailyPrice=400000, Description="Mercedes", ModelYear="2017"},
                new Car {CarId=4, BrandId=3, ColorId=2, DailyPrice=130000, Description="Fiat", ModelYear="2020"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(car);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
            
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
