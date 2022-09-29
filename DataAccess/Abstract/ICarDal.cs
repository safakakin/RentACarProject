using System;
using Entities.Concrete;

namespace DataAccess.Abstract
{
	public interface ICarDal
	{
        List<Car> GetByCarId(int carId);

        List<Car> GetAll();

        void Add(Car car);

        void Update(Car car);

        void Delete(Car car);
    }
}

