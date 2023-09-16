using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Menu : IMenuComponent
    {
        private readonly IList<IMenuComponent> menuComponents = new List<IMenuComponent>();

        private readonly string _name;
        private readonly string _description;
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

        public Menu(string name, string description)
        {
            _name = name;
            _description = description;
        }
        public string Show()
        {
            var displayMenu = GetMenuComponentInfo();
            for (int i = 0; i < menuComponents.Count; i++)
            {
                IMenuComponent menuComponent = menuComponents[i] as IMenuComponent;
                displayMenu += "\n" + menuComponent.Show();
            }
            return displayMenu;
        }

        private string GetMenuComponentInfo()
        {
            return _name + " " + _description;
        }

        public void Add(IMenuComponent menu)
        {
            menuComponents.Add(menu);
        }

        public void Remove(IMenuComponent menu)
        {
            menuComponents.Remove(menu);
        }
    }
}
