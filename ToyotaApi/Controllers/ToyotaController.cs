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
        
        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(_carsService.GetCars());
        }

        [HttpGet("model/{model}")]
        public IActionResult GetByModel(string model)
        {
            return Ok(_carsService.GetCarsByModel(model));
        }
        
        [HttpGet("transmission/{transmission}")]
        public IActionResult GetByTransmission(string transmission)
        {
            return Ok(_carsService.GetCarsByTransmission(transmission));
        }

        [HttpGet("year/{year}")]
        public IActionResult GetByYear(int year)
        {
            return Ok(_carsService.GetCarsByYear(year));
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_carsService.GetCarById(id));
        }
    }
}