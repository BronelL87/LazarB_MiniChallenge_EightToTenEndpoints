using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LazarB_MiniChallenge_EightToTenEndpoints.Services
{
    public class RestaurantPickerServices
    {

        public string PickRestaurant(string userInpt){
            string[] fastFood = {"McDonald's", "Burger King", "Wendy's", "Taco Bell", "KFC", "Chick-fil-A", "Subway", "Popeyes", "Sonic", "Jack in the Box"};

        string[] casualDining = {"Olive Garden", "Chili's", "Red Lobster", "Applebee's", "Texas Roadhouse", "Nona's Restaurant", "Cheesecake Factory", "Black Bear Diner", "Buffalo Wild Wings", "BJ's Restaurant and Brewhouse"};

        string[] fineDining = {"The Black Rabbit", "Market Tavern", "Prime Table", "Midgley's Public House", "Pietro's", "Ella Dining Room and Bar", "The Vine House", "Ernie's Food & Spirit", "Wildfire Public House", "Falcon's Lair"};

        Random picker = new();

        switch (userInpt.ToLower()){
            case "fast food":

            int restaurant = picker.Next(fastFood.Length);

            return $"For fast food I say you go to: {fastFood[restaurant]}";

            case "casual dining":

            restaurant = picker.Next(casualDining.Length);

            return $"For casual dining I say you go to: {casualDining[restaurant]}";

            case "fine dining":
            
            restaurant = picker.Next(fineDining.Length);

            return $"For fine dining I say you go to: {fineDining[restaurant]}";

            default:

            return "Invalid Input. must type either 'fast food', 'casual dining', or 'fine dining'";

        }
 
        }
       



    }
}