using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class Drinks : Dish
    {
        private bool _ishot;
        private bool _withSugar;

        public bool IsHot { get => _ishot; private set => _ishot = value; }
        public bool WithSugar { get => _withSugar; private set => _withSugar = value; }

        public Drinks(string name, int price, bool ishot, bool withSugar) : base(name, price)
        {
            _ishot = ishot;
            _withSugar = withSugar;
        }
    }
}
