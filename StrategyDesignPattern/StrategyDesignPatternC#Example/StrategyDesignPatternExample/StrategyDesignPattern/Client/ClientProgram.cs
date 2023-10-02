using StrategyDesignPatternExample.StrategyDesignPattern.Context;
using StrategyDesignPatternExample.StrategyDesignPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPatternExample.StrategyDesignPattern.Client
{
    // https://dotnettutorials.net/lesson/strategy-design-pattern/
    // https://dotnettutorials.net/lesson/strategy-design-pattern-real-time-example/
    // https://refactoring.guru/design-patterns/strategy
    // https://refactoring.guru/design-patterns/strategy/csharp/example#lang-features
    // https://www.ezzylearning.net/tutorial/strategy-pattern-in-asp-net-core

    class ClientProgram
    {
        static void Main(string[] args)
        {
            // The client code picks a concrete strategy and passes it to the
            // context. The client should be aware of the differences between
            // strategies in order to make the right choice.
            CompressionContext ctx = new CompressionContext(new ZipCompressionStrategy());
            ctx.CreateArchive("DotNetDesignPattern");

            ctx.SetStrategy(new RarCompressionStrategy());
            ctx.CreateArchive("DotNetDesignPattern");

            Console.Read();

            #region Method - II

            CompressionContext ctxTwo = null;
            //ctxTwo = new CompressionContext(); //Create the default constructor in the CompressionContext class

            if ("ZipCompression".Equals("ZipCompression", StringComparison.InvariantCultureIgnoreCase))
            {
                ctx.SetStrategy(new ZipCompressionStrategy());
            }
            else if ("RarCompression".Equals("RarCompression", StringComparison.InvariantCultureIgnoreCase))
            {
                ctx.SetStrategy(new RarCompressionStrategy());
            }

            #endregion
        }
    }
}
