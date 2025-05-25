using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class SerializeJSON
    {
    public class MenuDTO
    {
        public List<DishDTO> Dishes { get; set; }

        public MenuDTO()
        {
            Dishes = new List<DishDTO>();
        }
    }

    public class DishDTO
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

    public class RestaurantDTO
    {
        public string Name { get; set; }
        public MenuDTO Menu { get; set; }
        public MenuDTO SeasonalMenu { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string WorkingHours { get; set; }
        public int Rating { get; set; }
        public bool HasSeasonalMenu { get; set; }
    }
    private static readonly string FilePath = "restaurant_data.json";
    public void Serialize(List<Restaurant> restaurants){
        

    }
        


    }
}
