using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelPark.Business.Interfaces;
using HelPark.Business.IsPark;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HelPark.Business
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddBusiness(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient("IsPark", c =>
            {
                c.BaseAddress = new Uri(configuration.GetSection("OutSourceUrls").GetSection("IsparkUrl").Value);
                c.DefaultRequestHeaders.Add("Accept", "application/json");
            });

            services.AddSingleton<IIsParkService, IsParkService>();

            return services;
        }
    }
}
