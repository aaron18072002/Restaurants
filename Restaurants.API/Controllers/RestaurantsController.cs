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
            this._logger.LogInformation("{ControllerName}.{MethodName} action get method",
                nameof(RestaurantsController), nameof(this.GetAll));

            var restaurant = await this._restaurantsService.GetAllRestaurants();

            return this.Ok(restaurant);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetById([FromRoute]int id)
        {
            this._logger.LogInformation("{ControllerName}.{MethodName} action get method",
                nameof(RestaurantsController), nameof(this.GetById));

            var restaurant = await this._restaurantsService.GetRestaurantById(id);

            if(restaurant == null)
            {
                return this.NotFound();
            }

            return this.Ok(restaurant);
        }
    }
}
