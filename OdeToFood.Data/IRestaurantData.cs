using OdeToFood.Core;
using System.Linq;
using System.Collections.Generic;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Scott's Pizza", Location = "Liverpool", Cuisine = CuisineType.Indian},
                new Restaurant { Id = 2, Name = "Scott's Indian", Location = "Manchester", Cuisine = CuisineType.Indian},
                new Restaurant { Id = 3, Name = "Scott's Tacos", Location = "London", Cuisine = CuisineType.Mexican}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                orderby r.Id
                select r;
        }
    }
}