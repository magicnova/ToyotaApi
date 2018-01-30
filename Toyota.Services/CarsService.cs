using System.Collections.Generic;
using Toyota.Domain;
using Toyota.Domain.Interfaces;

namespace Toyota.Services
{
    public class CarsService :ICarsService
    {
        public IList<Car> GetCars()
        {
            throw new System.NotImplementedException();
        }

        public IList<Car> GetCarsByModel(string model)
        {
            throw new System.NotImplementedException();
        }

        public IList<Car> GetCarsByYear(int year)
        {
            throw new System.NotImplementedException();
        }

        public IList<Car> GetCarsByTransmission(string transmission)
        {
            throw new System.NotImplementedException();
        }

        public Car GetCarById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}