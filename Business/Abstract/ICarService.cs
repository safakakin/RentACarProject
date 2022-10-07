using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
	{
		List<Car> GetAll();
		Car GetByCarId(int carId);
		
		List<Car> GetAllByBrandId(int brandId);
        List<Car> GetAllByColorId(int colorId);

		void Add(Car car);
		void Delete(Car car);
		void Update(Car car);

		List<CarDetailDto> GetProductDetails();

    }
}

