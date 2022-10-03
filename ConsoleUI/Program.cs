
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());



carManager.Add(new Car { CarId = 6,ColorId=2,BrandId=5,DailyPrice=140000,Description="Guzel araç",ModelYear=1992 });

foreach (var car in carManager.GetAllByBrandId(5))
{
    Console.WriteLine(car.Description);
}

foreach (var car in carManager.GetAllByColorId(1))
{
    Console.WriteLine(car.ModelYear);
}