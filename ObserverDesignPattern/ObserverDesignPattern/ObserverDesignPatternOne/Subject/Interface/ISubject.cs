using ObserverDesignPattern.ObserverDesignPatternOne.Observer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.ObserverDesignPatternOne.Subject.Interface
{
    // https://dotnettutorials.net/lesson/observer-design-pattern/

    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}
