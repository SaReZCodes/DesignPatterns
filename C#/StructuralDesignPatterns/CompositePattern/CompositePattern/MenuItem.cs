using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class MenuItem : IMenuComponent
    {
        private readonly string _name;
        private readonly string _description;
        private readonly bool _isVegetarian;
        private readonly long _price;
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public string Dscription
        {
            get
            {
                return _description;
            }
        }
        public bool IsVegetarian
        {
            get
            {
                return _isVegetarian;
            }
        }
        public long Price
        {
            get
            {
                return _price;
            }
        }

        public MenuItem(string name, string description, bool isVegetarian, long price)
        {
            _name = name;
            _description = description;
            _price = price;
            _isVegetarian = isVegetarian;
        }
        public string Show()
        {
            var displayMenu = GetMenuComponentInfo();
            return displayMenu;
        }

        private string GetMenuComponentInfo()
        {
            return Name + " " +
                Dscription + " " +
                Price.ToString() + " " +
                ShowIfVeg(IsVegetarian);
        }

        public string ShowIfVeg(bool isVeg)
        {
            if (isVeg)
                return "V";
            else
                return "";

        }

    }
}
