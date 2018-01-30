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
        
        [HttpGet("{model}")]
        public IActionResult Get(string model)
        {
            return Ok(_carsService.GetCarsByModel(model));
        }
    }
}