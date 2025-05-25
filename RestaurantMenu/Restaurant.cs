using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public abstract partial class Restaurant : ISeasonalMenu
    {
        private IMenu? _seasonMenu;
        private string _name;
        private IMenu _menu;
        private string _address;
        private string _phoneNumber;
        private string _workingHours;
        private int _rating;

        public string Name { get => _name; }
        public IMenu SeasonalMenu { get => _seasonMenu ?? throw new InvalidOperationException("Seasonal menu is not set"); }
        public IMenu Menu { get => _menu; }
        public string Address { get => _address; }
        public string PhoneNumber { get => _phoneNumber; }
        public string WorkingHours { get => _workingHours; }
        public int Rating { get => _rating; }
        public bool HasSeasonalMenu { get => _seasonMenu != null ? true : false; }
        public Restaurant(string name, IMenu menu, string address, string phoneNumber, string workingHours, int rating)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name), "Название ресторана не может быть пустым");

            if (menu == null)
                throw new ArgumentNullException(nameof(menu), "Меню не может быть null");

            if (string.IsNullOrEmpty(address))
                throw new ArgumentNullException(nameof(address), "Адрес не может быть пустым");

            if (string.IsNullOrEmpty(phoneNumber))
                throw new ArgumentNullException(nameof(phoneNumber), "Номер телефона не может быть пустым");

            if (string.IsNullOrEmpty(workingHours))
                throw new ArgumentNullException(nameof(workingHours), "Время работы не может быть пустым");

            if (rating < 0 || rating > 5)
                throw new ArgumentException("Рейтинг должен быть от 0 до 5", nameof(rating));
            _name = name;
            _menu = menu;
            _address = address;
            _phoneNumber = phoneNumber;
            _workingHours = workingHours;
            _rating = rating;
            _seasonMenu = null;
        }
        public void AddSeasonalMenu(IMenu menu){
            if (menu == null)
            {
                throw new ArgumentNullException(nameof(menu), "Меню не может быть null");
            }
            _seasonMenu = menu;
        }
        public void RemoveSeasonalMenu(){
            _seasonMenu = null;
        }
    }
}
