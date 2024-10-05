using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurants.Application.Restaurants;

namespace Restaurants.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantsController : ControllerBase
    {
        private readonly IRestaurantsService _restaurantsService;
        private readonly ILogger<RestaurantsController> _logger;
        public RestaurantsController(IRestaurantsService restaurantsService, ILogger<RestaurantsController> logger)
        {
            this._restaurantsService = restaurantsService;
            this._logger = logger;
        }

        [HttpGet]
        [Route("")]
        [Route("[action]")]
        public async Task<IActionResult> GetAll()
        {
            var restaurant = await this._restaurantsService.GetAllRestaurants();

            return this.Ok(restaurant);
        }
    }
}
