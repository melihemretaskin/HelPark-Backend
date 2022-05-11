using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelPark.Core.Settings;
using HelPark.DataAccess.Repository;
using HelPark.Models.IsParkDTO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace HelPark.DataAccess
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IsParkDetailRepository>();
            services.AddSingleton<IsParkRepository>();

            services.Configure<MongoSettings>(settings =>
            {
                settings.ConnectionString = configuration.GetSection("MongoConnection").GetSection("ConnectionString").Value;
                settings.Database = configuration.GetSection("MongoConnection").GetSection("Database").Value;
            });

            return services;
        }
    }
}
