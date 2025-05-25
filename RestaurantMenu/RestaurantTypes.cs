using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class FullRestaurant : Restaurant
    {
        private bool _hasBar;
        private bool _hasTerrace;
        private int _tableCount;
        
        public bool HasBar { get => _hasBar; }
        public bool HasTerrace { get => _hasTerrace; }
        public int TableCount { get => _tableCount; }

        public FullRestaurant(string name, IMenu menu, string address, string phoneNumber, 
            string workingHours, int rating, bool hasBar, bool hasTerrace, int tableCount) 
            : base(name, menu, address, phoneNumber, workingHours, rating)
        {
            if (tableCount <= 0)
                throw new ArgumentException("Количество столов должно быть больше 0", nameof(tableCount));
                
            _hasBar = hasBar;
            _hasTerrace = hasTerrace;
            _tableCount = tableCount;
        }
    }

    public class Cafe : Restaurant
    {
        private bool _hasWiFi;
        private bool _hasPlayground;
        private int _maxCapacity;

        public bool HasWiFi { get => _hasWiFi; }
        public bool HasPlayground { get => _hasPlayground; }
        public int MaxCapacity { get => _maxCapacity; }

        public Cafe(string name, IMenu menu, string address, string phoneNumber, 
            string workingHours, int rating, bool hasWiFi, bool hasPlayground, int maxCapacity) 
            : base(name, menu, address, phoneNumber, workingHours, rating)
        {
            if (maxCapacity <= 0)
                throw new ArgumentException("Максимальная вместимость должна быть больше 0", nameof(maxCapacity));
                
            _hasWiFi = hasWiFi;
            _hasPlayground = hasPlayground;
            _maxCapacity = maxCapacity;
        }
    }

    public class CoffeeShop : Restaurant
    {
        private bool _hasRoasting;
        private string[] _coffeeTypes;
        private bool _hasTakeaway;

        public bool HasRoasting { get => _hasRoasting; }
        public string[] CoffeeTypes { get => _coffeeTypes; }
        public bool HasTakeaway { get => _hasTakeaway; }

        public CoffeeShop(string name, IMenu menu, string address, string phoneNumber, 
            string workingHours, int rating, bool hasRoasting, string[] coffeeTypes, bool hasTakeaway) 
            : base(name, menu, address, phoneNumber, workingHours, rating)
        {
            if (coffeeTypes == null)
                throw new ArgumentNullException(nameof(coffeeTypes), "Список типов кофе не может быть null");
                
            if (coffeeTypes.Length == 0)
                throw new ArgumentException("Список типов кофе не может быть пустым", nameof(coffeeTypes));
                
            if (coffeeTypes.Any(string.IsNullOrEmpty))
                throw new ArgumentException("Типы кофе не могут быть пустыми строками", nameof(coffeeTypes));
                
            _hasRoasting = hasRoasting;
            _coffeeTypes = coffeeTypes;
            _hasTakeaway = hasTakeaway;
        }
    }
} 