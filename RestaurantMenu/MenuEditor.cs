using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public partial class Menu : IMenu
    {
        public void AddDish(Dish dish)
        {
            if (dish == null) return;
            _dishes.Add(dish);
        }

        public void RemoveDish(Dish dish){
            if (dish == null) return;
            _dishes.Remove(dish);
        }

        public void RemoveDish(string name)
        {
            if (string.IsNullOrEmpty(name)) return;
            _dishes = _dishes.Where(d => d.Name != name).ToList();
        }

    }
}
