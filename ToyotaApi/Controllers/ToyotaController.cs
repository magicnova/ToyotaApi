using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Get()
        {
            var cars = _carsService.GetCars();
            
            if (cars.Count > 0)
            {
                return Ok();    
            }

            return NoContent();
        }

        [HttpGet("model/{model}")]
        public IActionResult GetByModel(string model)
        {
            var cars = _carsService.GetCarsByModel(model);

            if (cars.Count > 0)
            {
                return Ok(cars);    
            }
            
            return NoContent();
        }
        
        [HttpGet("transmission/{transmission}")]
        public IActionResult GetByTransmission(string transmission)
        {
            var cars = _carsService.GetCarsByTransmission(transmission);

            if (cars.Count > 0)
            {
                return Ok(cars);    
            }

            return NoContent();
        }

        [HttpGet("year/{year}")]
        public IActionResult GetByYear(int year)
        {
            var cars = _carsService.GetCarsByYear(year);

            if (cars.Count > 0)
            {
                return Ok(cars);    
            }

            return NoContent();
        }
        
        [HttpGet("engine/{engine}")]
        public IActionResult GetByEngine(string engine)
        {
            var cars = _carsService.GetCarsByEngine(engine);
            
            if (cars.Count > 0)
            {
                return Ok(cars);    
            }

            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var car = _carsService.GetCarById(id);

            if (car != null)
            {
                return Ok(car);    
            }

            return NoContent();
        }
    }
}