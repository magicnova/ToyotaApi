using Microsoft.Extensions.DependencyInjection;
using Toyota.Domain.Interfaces;

namespace ToyotaApi.IOC
{
    public class Container
    {
        public void Module(IServiceCollection services)
        {
            services.AddTransient<ICarsService, ICarsService>();
        }
    }
}