using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.ObserverDesignPatternOne.Observer.Interface
{
    // https://dotnettutorials.net/lesson/observer-design-pattern/
    public interface IObserver
    {
        // Receive update from subject
        void Update(string availability);
    }
}
