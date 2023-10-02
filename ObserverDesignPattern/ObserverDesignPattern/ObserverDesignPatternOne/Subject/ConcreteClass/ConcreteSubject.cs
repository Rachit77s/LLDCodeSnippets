using ObserverDesignPattern.ObserverDesignPatternOne.Observer.ConcreteClass;
using ObserverDesignPattern.ObserverDesignPatternOne.Observer.Interface;
using ObserverDesignPattern.ObserverDesignPatternOne.Subject.Interface;
using System;
using System.Collections.Generic;

namespace ObserverDesignPattern.ObserverDesignPatternOne.Subject.ConcreteClass
{
    // The Subject owns some important state and notifies observers when the state changes.
    public class ConcreteSubject : ISubject
    {
        // List of subscribers. In real life, the list of subscribers can be
        // stored more comprehensively (categorized by event type, etc.).
        private List<IObserver> _observers = new List<IObserver>();

        private string _productName { get; set; }
        private int _productPrice { get; set; }
        private string _availability { get; set; }

        public ConcreteSubject(string productName, int productPrice, string availability)
        {
            _productName = productName;
            _productPrice = productPrice;
            _availability = availability;
        }

        public string GetAvailability()
        {
            return _availability;
        }

        // Product is now available, hence, notify all the registered Users/Observers
        public void SetAvailability(string availability)
        {
            this._availability = availability;
            Console.WriteLine("Availability changed from Out of Stock to Available.");
            NotifyObservers();
        }

        // Register/Add the User/Observer to the List of Observers
        public void RegisterObserver(IObserver observer)
        {
            Console.WriteLine("Observer Added : " + ((ConcreteObserver)observer).UserName);
            _observers.Add(observer);
        }

        //public void AddObservers(IObserver observer)
        //{
        //    observers.Add(observer);
        //}

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        // Trigger an update in each subscriber. Call the Observer class Update method to send notification.
        public void NotifyObservers()
        {
            Console.WriteLine("Product Name :"
                            + _productName + ", product Price : "
                            + _productPrice + " is Now available. So notifying all Registered users ");
           
            Console.WriteLine();

            foreach (IObserver observer in _observers)
            {
                observer.Update(_availability);
            }
        }
    }
}
