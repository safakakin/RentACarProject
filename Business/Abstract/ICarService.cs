using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
	{
		IDataResult<List<Car>> GetAll();
		IDataResult<Car> GetByCarId(int carId);
		IDataResult<List<Car>> GetAllByBrandId(int brandId);
        IDataResult<List<Car>> GetAllByColorId(int colorId);
		IResult Add(Car car);
		IResult Delete(Car car);
		IResult Update(Car car);
		IDataResult<List<CarDetailDto>> GetProductDetails();

    }
}

