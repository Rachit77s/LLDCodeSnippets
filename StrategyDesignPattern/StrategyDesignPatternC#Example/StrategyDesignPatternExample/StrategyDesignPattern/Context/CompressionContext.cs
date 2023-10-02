using StrategyDesignPatternExample.StrategyDesignPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPatternExample.StrategyDesignPattern.Context
{
    // The Context defines the interface of interest to clients.
    // This context class contains a property that is used to hold the reference of a Strategy object. This property will be set at run-time by the client according to the algorithm that is required.
    public class CompressionContext
    {
        // The Context maintains a reference to one of the Strategy objects. The
        // Context does not know the concrete class of a strategy. It should
        // work with all strategies via the Strategy interface.
        private ICompressionStrategy _compression;

        public CompressionContext(ICompressionStrategy Compression)
        {
            this._compression = Compression;
        }

        // Usually, the Context accepts a strategy through the constructor, but
        // also provides a setter to change it at runtime.
        // The Client will set what CompressionStrategy to use by calling this method at runtime
        public void SetStrategy(ICompressionStrategy Compression)
        {
            this._compression = Compression;
        }

        // The Context delegates some work to the Strategy object instead of
        // implementing multiple versions of the algorithm on its own.
        public void CreateArchive(string compressedArchiveFileName)
        {
            _compression.CompressFolder(compressedArchiveFileName);
        }
    }
}
