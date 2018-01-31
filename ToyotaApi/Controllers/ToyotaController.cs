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
        
        ///<remarks>This method will return all the cars.</remarks>
        [HttpGet]
        public IList<Car> Get()
        {
           return _carsService.GetCars();
        }
        
        ///<remarks>This method will return all the cars that match with the model.</remarks>
        [HttpGet("model/{model}")]
        public IList<Car> GetByModel(string model)
        {
            return _carsService.GetCarsByModel(model);
        }
        
        ///<remarks>This method will return all the cars that match with the transmission.</remarks>
        [HttpGet("transmission/{transmission}")]
        public IList<Car> GetByTransmission(string transmission)
        {
          return _carsService.GetCarsByTransmission(transmission);
        }

        ///<remarks>This method will return all the cars that match with the year.</remarks>
        [HttpGet("year/{year}")]
        public IList<Car> GetByYear(int year)
        {
            return _carsService.GetCarsByYear(year);
        }
        
        ///<remarks>This method will return all the cars that match with the engine.</remarks>
        [HttpGet("engine/{engine}")]
        public IList<Car> GetByEngine(string engine)
        {
            return _carsService.GetCarsByEngine(engine);
        }
        
        ///<remarks>This method will return all the cars that match with the id.</remarks>
        [HttpGet("{id}")]
        public Car GetById(int id)
        {
            return _carsService.GetCarById(id);
        }
    }
}