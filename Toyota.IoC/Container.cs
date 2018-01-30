using Microsoft.Extensions.DependencyInjection;
using Toyota.Domain.Interfaces;
using Toyota.Infrastructure.Data.Cars;
using Toyota.Infrastructure.Data.Cars.Interfaces;
using Toyota.Services;

namespace Toyota.IoC
{
    public class Container
    {
        public void Module(IServiceCollection services)
        {
            services.AddTransient<ICarsService, CarsService>();
            services.AddTransient<ICarsRepository, CarsRepository>();
        }
    }
}