using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Toyota.Domain;
using Toyota.Domain.Interfaces;

namespace ToyotaApi.Controllers
{
    [Route("api/[controller]")]
    public class ToyotaController : Controller
    {
        private readonly ICarsService _carsService;

        public ToyotaController(ICarsService carsService)
        {
            _carsService = carsService;
        }
        
        [HttpGet]
        public IList<Car> Get()
        {
           return _carsService.GetCars();
        }

        [HttpGet("model/{model}")]
        public IList<Car> GetByModel(string model)
        {
            return _carsService.GetCarsByModel(model);
        }
        
        [HttpGet("transmission/{transmission}")]
        public IList<Car> GetByTransmission(string transmission)
        {
          return _carsService.GetCarsByTransmission(transmission);
        }

        [HttpGet("year/{year}")]
        public IList<Car> GetByYear(int year)
        {
            return _carsService.GetCarsByYear(year);
        }
        
        [HttpGet("engine/{engine}")]
        public IList<Car> GetByEngine(string engine)
        {
            return _carsService.GetCarsByEngine(engine);
        }

        [HttpGet("{id}")]
        public Car GetById(int id)
        {
            return _carsService.GetCarById(id);
        }
    }
}