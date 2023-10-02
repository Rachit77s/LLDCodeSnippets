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
    class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as ConcreteSubject).State == 0 || (subject as ConcreteSubject).State >= 2)
            {
                Console.WriteLine("ConcreteObserverB: Reacted to the event.");
            }
        }
    }
}
