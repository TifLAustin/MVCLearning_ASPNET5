using System;
using System.Collections.Generic;
using System.Linq;
using Tutorial.Data.Models;

namespace Tutorial.Data.Services
{
    /// <summary>
    /// Restaurant Data that is held in memory
    /// </summary>
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            { 
                //temporary code to add data - to be replaced
                new Restaurant {Id = 1, Name = "David's Pizza", Cuisine = CuisineType.Italian },
                new Restaurant {Id = 2, Name = "Marrie's Delicacies", Cuisine = CuisineType.French},
                new Restaurant {Id = 3, Name = "Mango Grove", Cuisine = CuisineType.Indian}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            //Use linq to order by restaurant
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
