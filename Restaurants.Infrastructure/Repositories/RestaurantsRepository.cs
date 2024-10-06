using Microsoft.EntityFrameworkCore;
using Restaurants.Domain.Entities;
using Restaurants.Domain.Repositories;
using Restaurants.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Infrastructure.Repositories
{
    internal class RestaurantsRepository : IRestaurantsRepository
    {
        private readonly RestaurantsDbContext _db;
        public RestaurantsRepository(RestaurantsDbContext db)
        {
            this._db = db;
        }

        public async Task<IEnumerable<Restaurant>> GetAllAsync()
        {
            var restaurant = await this._db.Restaurants.ToListAsync();

            return restaurant;
        }

        public async Task<Restaurant?> GetByIdAsync(int id)
        {
            var restaurant = await this._db.Restaurants.FirstOrDefaultAsync
                (r => r.Id == id);

            return restaurant;
        }
    }
}
