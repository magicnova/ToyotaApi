using System.Collections.Generic;
using System.Linq;
using Toyota.Domain;
using Toyota.Infrastructure.Data.Cars.Interfaces;
using Toyota.Infrastructure.Data.Cars.Mocks;

namespace Toyota.Infrastructure.Data.Cars
{
    public class CarsRepository :ICarsRepository
    {
        public IList<Car> GetCars()
        {
            var factory = new CarsFactory();
            return factory.CreateCars();
        }

        public IList<Car> GetCarsByModel(string model)
        {
            var factory = new CarsFactory();
            var cars = factory.CreateCars();
            
            return cars.Where(where => where.Model.ToLower() == model.ToLower()).ToList();
        }

        public IList<Car> GetCarsByYear(int year)
        {
            var factory = new CarsFactory();
            var cars = factory.CreateCars();
            
            return cars.Where(where => where.Year == year).ToList();
        }

        public IList<Car> GetCarsByTransmission(string transmission)
        {
            var factory = new CarsFactory();
            var cars = factory.CreateCars();
            return cars.Where(where => where.Transmission.ToLower() == transmission.ToLower() ).ToList();
        }

        public Car GetCarById(int id)
        {
            var factory = new CarsFactory();
            var cars = factory.CreateCars();

            return cars.First(where => where.Id == id);
        }
    }
}