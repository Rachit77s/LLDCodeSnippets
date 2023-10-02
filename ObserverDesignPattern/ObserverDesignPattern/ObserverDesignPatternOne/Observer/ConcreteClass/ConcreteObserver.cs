using ObserverDesignPattern.ObserverDesignPatternOne.Observer.Interface;
using ObserverDesignPattern.ObserverDesignPatternOne.Subject.Interface;
using System;

namespace ObserverDesignPattern.ObserverDesignPatternOne.Observer.ConcreteClass
{
    // Concrete Observers react to the updates issued by the Subject they had been attached to.
    public class ConcreteObserver : IObserver
    {
        public string UserName { get; set; }

        // When new user is created, it would be registered/added to the list of Observers/Subscribers
        public ConcreteObserver(string userName, ISubject subject)
        {
            UserName = userName;

            // On creation of the new user, automatically register it to subscribe to the subject.
            subject.RegisterObserver(this);
        }

        public void Update(string availabiliy)
        {
            Console.WriteLine("Hello " + UserName + ", Product is now " + availabiliy + " on Amazon");
        }
    }
}
