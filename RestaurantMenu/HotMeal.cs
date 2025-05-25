using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    internal class HotMeal : Dish
    {
        private int _cookingTime;
        private int _temperature;
        private bool _isSpicy;
        private int _portionWeight;
        private bool _isVegetarian;

        public int CookingTime { get => _cookingTime; }
        public int Temperature { get => _temperature; }
        public bool IsSpicy { get => _isSpicy; }
        public int PortionWeight { get => _portionWeight; }
        public bool IsVegetarian { get => _isVegetarian; }

        public HotMeal(string name, int price, int cookingTime, int temperature, 
            bool isSpicy, int portionWeight, bool isVegetarian) 
            : base(name, price)
        {
            _cookingTime = cookingTime;
            _temperature = temperature;
            _isSpicy = isSpicy;
            _portionWeight = portionWeight;
            _isVegetarian = isVegetarian;
        }
    }
}
