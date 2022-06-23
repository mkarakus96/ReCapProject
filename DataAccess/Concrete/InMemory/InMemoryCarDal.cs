using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car> 
            {
            new Car { CarId = 2, BrandId = 1, ColorId = 1, ModelYear = 2006, CarName = "Renault", DailyPrice = 150, Description = "1.4 Benzin" },
            new Car { CarId = 3, BrandId = 2, ColorId = 2, ModelYear = 2010, CarName = "Audi", DailyPrice = 450, Description = "2.0 Dizel" },
            new Car { CarId = 4, BrandId = 3, ColorId = 1, ModelYear = 2015, CarName = "Fiat", DailyPrice = 300, Description = "1.6 Multijet Dizel" },
            new Car { CarId = 5, BrandId = 4, ColorId = 1, ModelYear = 2022, CarName = "Honda", DailyPrice = 1000, Description = "1.5 Benzin" },
            };
        }
        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
