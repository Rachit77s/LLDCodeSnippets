using CommandDesignPattern.CommandDesignPatternTwo.Command.Enum;
using CommandDesignPattern.CommandDesignPatternTwo.Command.Interface;
using CommandDesignPattern.CommandDesignPatternTwo.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.CommandDesignPatternTwo.Command.Models
{
    public class ProductCommand : IProductCommand
    {
        private readonly ProductReceiver _productReceiver; 
        private readonly PriceAction _priceAction;
        private readonly int _amount;

        public ProductCommand(ProductReceiver product, PriceAction priceAction, int amount)
        {
            _productReceiver = product;
            _priceAction = priceAction;
            _amount = amount;
        }

        public void ExecuteAction()
        {
            if (_priceAction == PriceAction.Increase)
            {
                _productReceiver.IncreasePrice(_amount);
            }
            else
            {
                _productReceiver.DecreasePrice(_amount);
            }
        }
    }
}
