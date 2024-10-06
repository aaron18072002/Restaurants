using Restaurants.Domain.Entities;
using Restaurants.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Application.Restaurants
{
    internal class RestaurantsService : IRestaurantsService
    {
        private readonly IRestaurantsRepository _restaurantsRepository;
        public RestaurantsService(IRestaurantsRepository restaurantsRepository)
        {
            this._restaurantsRepository = restaurantsRepository;
        }

        public async Task<IEnumerable<Restaurant>> GetAllRestaurants()
        {
            var restaurants = await this._restaurantsRepository.GetAllAsync();

            return restaurants;
        }

        public async Task<Restaurant?> GetRestaurantById(int id)
        {
            var restaurant = await this._restaurantsRepository.GetByIdAsync(id);

            return restaurant;
        }
    }
}
