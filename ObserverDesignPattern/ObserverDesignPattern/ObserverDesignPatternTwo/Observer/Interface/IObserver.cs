using ObserverDesignPattern.ObserverDesignPatternTwo.Subject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.ObserverDesignPatternTwo.Observer.Interface
{
    public interface IObserver
    {
        // Receive update from subject
        void Update(ISubject subject);
    }
}
