using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    // https://refactoring.guru/design-patterns/adapter/csharp/example
    // https://refactoring.guru/design-patterns/adapter

    // https://www.dofactory.com/net/adapter-design-pattern

    class ConceptualExample
    {

    }
    //Above is Client Class

    // The Target defines the domain-specific interface used by the client code.
    // Rachit: This is a Client Class Interface we created 
    public interface ITarget
    {
        string GetRequest();
    }

    // The Adaptee contains some useful behavior, but its interface is
    // incompatible with the existing client code. The Adaptee needs some
    // adaptation before the client code can use it.

    // Rachit: This is a 3rd party class/code which we need to integrate with our current code
    class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request.";
        }
    }

    // The Adapter makes the Adaptee's interface(3rd party code) compatible with the Target's interface(Client class code i.e. Current class code).
    class Adapter : ITarget
    {
        // Rachit: 3rd party class reference
        private readonly Adaptee _adaptee;

        // Rachit: Constructor based DI
        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetRequest()
        {
            // Rachit: Call 3rd party method
            return $"This is '{this._adaptee.GetSpecificRequest()}'";
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
              // Rachit: Create 3rd party class/service class object
    //        Adaptee adaptee = new Adaptee();
    //        ITarget target = new Adapter(adaptee);

    //        Console.WriteLine("Adaptee interface is incompatible with the client.");
    //        Console.WriteLine("But with adapter client can call it's method.");

    //        Console.WriteLine(target.GetRequest());
    //    }
    //}
}
