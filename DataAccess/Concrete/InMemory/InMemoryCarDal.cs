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
        List<Car> _car;
        public InMemoryCarDal()  // ctor tab tab
        {
            _car = new List<Car>
            {
                new Car{ProductId=1, ColorId=1,BrandId=1,DailyPrice=500,Description="Mercedes",ModelYear="2019"},
                new Car{ProductId=1, ColorId=2,BrandId=1,DailyPrice=800,Description="Mercedes",ModelYear="2019"},
                new Car{ProductId=1, ColorId=3,BrandId=2,DailyPrice=750,Description="BMW",ModelYear="2018"},
                new Car{ProductId=1, ColorId=2,BrandId=3,DailyPrice=900,Description="Mazda",ModelYear="2020"},
                new Car{ProductId=1, ColorId=1,BrandId=4,DailyPrice=800,Description="Jeep",ModelYear="2017"},
                new Car{ProductId=1, ColorId=1,BrandId=6,DailyPrice=950,Description="Range Rover",ModelYear="2015"},
                new Car{ProductId=1, ColorId=3,BrandId=5,DailyPrice=900,Description="Honda",ModelYear="2021"},

            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;
            carToDelete = _car.SingleOrDefault(c => c.ProductId == car.ProductId); 
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int productId)
        {
            return _car.Where(c => c.ProductId== productId).ToList();
           
        }

        public List<Car> GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.ProductId == car.ProductId);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId= car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.ProductId = car.ProductId;
        }
    }
}
