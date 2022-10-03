using System;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{

    
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear=2019,DailyPrice=150000,Description="Sedan"},
                new Car{CarId=2,BrandId=1,ColorId=2,ModelYear=2020,DailyPrice=200000,Description="UTV"},
                new Car{CarId=3,BrandId=2,ColorId=3,ModelYear=2017,DailyPrice=145000,Description="Jeep"},
                new Car{CarId=4,BrandId=2,ColorId=4,ModelYear=2018,DailyPrice=123000,Description="Truck"},
                new Car{CarId=5,BrandId=2,ColorId=5,ModelYear=2009,DailyPrice=99000,Description="Station"},
            };
        }
        
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;

            carToDelete=_cars.SingleOrDefault(c=>c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate;
            carToUpdate= _cars.SingleOrDefault(c => c.CarId == car.CarId);

            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}

