using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.CommandDesignPatternTwo.Receiver
{
    // The Receiver classes contain some important business logic. They know how
    // to perform all kinds of operations, associated with carrying out a
    // request. In fact, any class may serve as a Receiver.

    public class ProductReceiver
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public ProductReceiver(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public void IncreasePrice(int amount)
        {
            Price += amount;
            Console.WriteLine($"The price for the {Name} has been increased by {amount}$.");
        }
        public void DecreasePrice(int amount)
        {
            if (amount < Price)
            {
                Price -= amount;
                Console.WriteLine($"The price for the {Name} has been decreased by {amount}$.");
            }
        }
        public override string ToString() => $"Current price for the {Name} product is {Price}$.";

    }
}
