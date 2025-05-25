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

        public int CookingTime { get => _cookingTime; private set => _cookingTime = value; }
        public int Temperature { get => _temperature; private set => _temperature = value; }
        public bool IsSpicy { get => _isSpicy; private set => _isSpicy = value; }
        public int PortionWeight { get => _portionWeight; private set => _portionWeight = value; }
        public bool IsVegetarian { get => _isVegetarian; private set => _isVegetarian = value; }

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
