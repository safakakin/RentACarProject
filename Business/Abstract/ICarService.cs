using System;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface ICarService
	{
		List<Car> GetAll();
		List<Car> GetAllByCategoryId(int id);
		List<Car> GetAllByBrandId(int brandId);
        List<Car> GetAllByColorId(int colorId);
		void Add(Car car);
		void Delete(Car car);
		void Update(Car car);

    }
}

