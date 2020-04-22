using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurant
{
    public class ListModel : PageModel
    {
        private readonly IRestaurantData restaurantData;

        public IEnumerable<OdeToFood.Core.Restaurant> restaurants { get; set; }
        [BindProperty(SupportsGet =true)]
        public string SearchTerm { get; set; }
        public ListModel(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }
        public void OnGet()
        {
            restaurants = restaurantData.GetAllRestaurantsByName(SearchTerm);
        }
    }
}