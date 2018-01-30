using System.Collections.Generic;
using Toyota.Domain;
using Toyota.Domain.Interfaces;
using Toyota.Infrastructure.Data.Cars.Interfaces;

namespace Toyota.Services
{
    public class CarsService :ICarsService
    {
        private readonly ICarsRepository _carsRepository;

        public CarsService(ICarsRepository carsRepository)
        {
            _carsRepository = carsRepository;
        }

        public IList<Car> GetCars()
        {
            return _carsRepository.GetCars();
        }

        public IList<Car> GetCarsByModel(string model)
        {
            return _carsRepository.GetCarsByModel(model);
        }

        public IList<Car> GetCarsByYear(int year)
        {
            return _carsRepository.GetCarsByYear(year);
        }

        public IList<Car> GetCarsByTransmission(string transmission)
        {
            return _carsRepository.GetCarsByTransmission(transmission);
        }

        public Car GetCarById(int id)
        {
            return _carsRepository.GetCarById(id);
        }
    }
}