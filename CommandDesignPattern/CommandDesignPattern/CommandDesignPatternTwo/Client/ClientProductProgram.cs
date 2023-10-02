using CommandDesignPattern.CommandDesignPatternTwo.Command.Enum;
using CommandDesignPattern.CommandDesignPatternTwo.Command.Interface;
using CommandDesignPattern.CommandDesignPatternTwo.Command.Models;
using CommandDesignPattern.CommandDesignPatternTwo.Invoker;
using CommandDesignPattern.CommandDesignPatternTwo.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.CommandDesignPatternTwo.Client
{
    class ClientProductProgram
    {
        static void MainABC(string[] args)
        {
            var modifyPrice = new ModifyPriceInvoker();

            var product = new ProductReceiver("Phone", 500);

            // The client will create the command object
            Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Increase, 100));

            Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Increase, 50));
            Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Decrease, 25));
            Console.WriteLine(product);
        }
        private static void Execute(ProductReceiver product, ModifyPriceInvoker modifyPrice, IProductCommand productCommand)
        {
            modifyPrice.SetCommand(productCommand);
            modifyPrice.Invoke();
        }
    }
}
