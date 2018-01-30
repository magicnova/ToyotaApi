using System.Collections.Generic;
using Toyota.Domain;

namespace Toyota.Infrastructure.Data.Cars.Interfaces
{
    public interface ICarsRepository
    {
        IList<Car> GetCars();
        IList<Car> GetCarsByModel(string model);
        IList<Car> GetCarsByYear(int year);
        IList<Car> GetCarsByTransmission(string transmission);
        IList<Car> GetCarsByEngine(string engine);
        Car GetCarById(int id);
    }
}