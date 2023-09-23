using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Observable
    {
        private readonly List<Observer> observers = new List<Observer>();

        public void Attach(Observer observer) => observers.Add(observer);

        public void UnAttach(Observer observer) => observers.Remove(observer);
        public void NotifyAllObservers()
        {
            foreach (var item in observers)
            {
                item.Update(); 
            }
        }
    }
}
