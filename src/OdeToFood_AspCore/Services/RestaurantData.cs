using System.Collections.Generic;
using System.Linq;
using OdeToFood_AspCore.Entities;

namespace OdeToFood_AspCore.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
        Restaurant Add(Restaurant restaurant);
    }
    public class InMemoryRestaurantData : IRestaurantData
    {
        static InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant {Id = 1,Name = "The House of Kobe"},
                new Restaurant {Id = 2,Name = "Tulip"},
                new Restaurant {Id = 3,Name = "Zizi's"}
            };
        }
        
        private static List<Restaurant> _restaurants;
        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }

        public Restaurant Add(Restaurant restaurant)
        {
            restaurant.Id = _restaurants.Max(r => r.Id) + 1;
            _restaurants.Add(restaurant);

            return restaurant;

        }
    }
}
