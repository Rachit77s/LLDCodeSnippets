using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://dotnettutorials.net/lesson/strategy-design-pattern/
// https://dotnettutorials.net/lesson/strategy-design-pattern-real-time-example/
// https://refactoring.guru/design-patterns/strategy
// https://refactoring.guru/design-patterns/strategy/csharp/example#lang-features
// https://www.ezzylearning.net/tutorial/strategy-pattern-in-asp-net-core


namespace StrategyDesignPatternExample.StrategyDesignPattern.Strategy
{
    // The Strategy interface declares operations common to all supported
    // versions of some algorithm.
    //
    // The Context uses this interface to call the algorithm defined by Concrete
    // Strategies.
    public interface ICompressionStrategy
    {
        void CompressFolder(string compressedArchiveFileName);
    }
}
