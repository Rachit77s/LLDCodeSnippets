using ObserverDesignPattern.ObserverDesignPatternOne.Observer.ConcreteClass;
using ObserverDesignPattern.ObserverDesignPatternOne.Subject.ConcreteClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.ObserverDesignPatternOne.Client
{
    class ClientProgram
    {
        static void Main(string[] args)
        {
            //Create a Product with Out Of Stock Status
            ConcreteSubject RedMI = new ConcreteSubject("Red MI Mobile", 10000, "Out Of Stock");

            //User Anurag will be created and user1 object will be registered to the subject
            ConcreteObserver user1 = new ConcreteObserver("Anurag", RedMI);

            //User Pranaya will be created and user1 object will be registered to the subject
            ConcreteObserver user2 = new ConcreteObserver("Pranaya", RedMI);

            //User Priyanka will be created and user3 object will be registered to the subject
            ConcreteObserver user3 = new ConcreteObserver("Priyanka", RedMI);

            Console.WriteLine("Red MI Mobile current state : " + RedMI.GetAvailability());
            Console.WriteLine();

            // Now product is available
            RedMI.SetAvailability("Available");
            Console.Read();
        }
    }
}
