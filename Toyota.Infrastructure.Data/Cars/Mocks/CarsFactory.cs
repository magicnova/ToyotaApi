using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO.Pipes;
using System.Xml.Schema;
using Toyota.Domain;

namespace Toyota.Infrastructure.Data.Cars.Mocks
{
    public class CarsFactory
    {
         public IList<Car> CreateCars()
         {
             return new List<Car>()
             {
                 CreateCar(1, "", "Camry", "automatic", 2018),
                 CreateCar(2, "", "Camry", "manual", 2016),
                 CreateCar(3, "", "Crown", "automatic", 2018),
                 CreateCar(4, "", "Allion", "manual", 2018),
                 CreateCar(5, "", "MarkX", "manual", 2017),
                 CreateCar(6, "", "Corolla", "automatic", 2017),
                 CreateCar(7, "", "Hilux", "manual", 2017),
                 CreateCar(8, "", "Allion", "automatic", 2015),
                 CreateCar(9, "", "Hilux", "automatic", 2015),
                 CreateCar(10, "", "Corolla", "manual", 2014)
             };
         }

        private Car CreateCar(int id, string engine, string model, string transmission, int year)
        {
            return new Car
            {
                Id = id,
                Engine = engine,
                Model = model,
                Transmission = transmission,
                Year = year
            };
        }
    }
}