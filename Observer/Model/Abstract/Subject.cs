using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Model.Abstract
{
    public abstract class Subject
    {
        private readonly List<Observer> _observers = new List<Observer>();

        public void Register(Observer abstractObserver)
        {
            _observers.Add(abstractObserver);
        }

        public void Unregister(Observer abstractObserver)
        {
            _observers.Remove(abstractObserver);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
