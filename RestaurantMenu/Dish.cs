using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class Dish
    {
        private string _name;
        private int _price;
        public string Name { get => _name; }
        public int Price { get => _price; }
        public Dish(string name, int price)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));
            _name = name;
            _price = price;
        }
    }
}
