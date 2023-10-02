using CommandDesignPattern.CommandDesignPatternTwo.Command.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.CommandDesignPatternTwo.Invoker
{
    public class ModifyPriceInvoker
    {
        private readonly List<IProductCommand> _commands;
        private IProductCommand _command;

        public ModifyPriceInvoker()
        {
            _commands = new List<IProductCommand>();
        }

        public void SetCommand(IProductCommand command) => _command = command;

        public void Invoke()
        {
            _commands.Add(_command);
            _command.ExecuteAction();
        }

    }
}
