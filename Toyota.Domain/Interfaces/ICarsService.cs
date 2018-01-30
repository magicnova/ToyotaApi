using System.Collections.Generic;

namespace Toyota.Domain.Interfaces
{
    public interface ICarsService
    {
       IList<Car> GetCars();
       IList<Car> GetCarsByModel(string model);
       IList<Car> GetCarsByYear(int year);
       IList<Car> GetCarsByTransmission(string transmission);
        IList<Car> GetCarsByEngine(string engine);
       Car GetCarById(int id);
    }
}