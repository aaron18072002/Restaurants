using Microsoft.Extensions.DependencyInjection;
using Restaurants.Application.Restaurants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Application.Extensions
{
    public static class ServicesCollectionExtension
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IRestaurantsService, RestaurantsService>();
        }
    }
}
