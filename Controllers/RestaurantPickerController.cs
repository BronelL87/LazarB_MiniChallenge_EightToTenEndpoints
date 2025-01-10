using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LazarB_MiniChallenge_EightToTenEndpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace LazarB_MiniChallenge_EightToTenEndpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerServices _restaurantPickerServices;

        public RestaurantPickerController(RestaurantPickerServices restaurantPickerServices){
            _restaurantPickerServices = restaurantPickerServices;
        }


        [HttpPost]
        [Route("PickerRestaurant/{fastCasualFine}")]


        public string RandomRestaurant(string fastCasualFine){
            return _restaurantPickerServices.PickRestaurant(fastCasualFine);
        }
    }    
}