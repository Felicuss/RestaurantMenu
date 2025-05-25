using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    public interface ISeasonalMenu
    {
        IMenu SeasonalMenu { get; }
        void AddSeasonalMenu(IMenu menu);
        void RemoveSeasonalMenu();
        bool HasSeasonalMenu { get; }
    }
} 