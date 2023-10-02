using ObserverDesignPattern.ObserverDesignPatternTwo.Observer.ConcreteClass;
using ObserverDesignPattern.ObserverDesignPatternTwo.Subject.ConcreteClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.ObserverDesignPatternTwo.Client
{
    class ClientProgram
    {
        static void MainABC(string[] args)
        {
            // The client code.
            var subject = new ConcreteSubject();
            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Detach(observerB);

            subject.SomeBusinessLogic();
        }
    }
}
