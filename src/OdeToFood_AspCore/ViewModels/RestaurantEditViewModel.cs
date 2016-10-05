using OdeToFood_AspCore.Entities;

namespace OdeToFood_AspCore.ViewModels
{
    public class RestaurantEditViewModel
    {
        public string Name { get; set; }

        public CuisineType Cuisine { get; set; }
    }
}
