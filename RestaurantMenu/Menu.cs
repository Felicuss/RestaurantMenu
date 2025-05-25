using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public partial class Menu : IMenu
    {
        private List<Dish> _dishes;
        public List<Dish> Dishes { get { return _dishes?.ToList() ?? new List<Dish>(); } }
        
        public Menu(List<Dish> dishes)
        {
            _dishes = dishes ?? new List<Dish>();
        }
    }
}
