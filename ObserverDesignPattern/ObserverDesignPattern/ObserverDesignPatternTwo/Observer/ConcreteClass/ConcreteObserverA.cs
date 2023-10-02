using ObserverDesignPattern.ObserverDesignPatternTwo.Observer.Interface;
using ObserverDesignPattern.ObserverDesignPatternTwo.Subject.ConcreteClass;
using ObserverDesignPattern.ObserverDesignPatternTwo.Subject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.ObserverDesignPatternTwo.Observer.ConcreteClass
{
    // Concrete Observers react to the updates issued by the Subject they had
    // been attached to.
    class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as ConcreteSubject).State < 3)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }
        }
    }
}
