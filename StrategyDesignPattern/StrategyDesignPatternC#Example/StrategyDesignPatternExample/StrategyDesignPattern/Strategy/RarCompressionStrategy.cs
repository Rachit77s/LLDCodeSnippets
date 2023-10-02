using System;

namespace StrategyDesignPatternExample.StrategyDesignPattern.Strategy
{
    public class RarCompressionStrategy : ICompressionStrategy
    {
        public void CompressFolder(string compressedArchiveFileName)
        {
            Console.WriteLine("Folder is compressed using Rar approach: '" + compressedArchiveFileName
                 + ".rar' file is created");
        }
    }
}
