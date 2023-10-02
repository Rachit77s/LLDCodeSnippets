using CommandDesignPattern.CommandDesignPattern.Command.Interface;
using CommandDesignPattern.CommandDesignPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.CommandDesignPattern.Command.Models
{
    // Some commands can delegate more complex operations to other
    // objects, called "receivers."

    // As per the command design pattern the command has three things. The first one is the request i.e. the command. The second one is the Receiver object reference and the third one is the Execute method which will call the receiver object method to handle the request.
    public class CloseCommand : ICommand
    {
        // "receivers." object
        private DocumentReceiver document;
        public CloseCommand(DocumentReceiver doc)
        {
            document = doc;
        }
        public void Execute()
        {
            document.Close();
        }
    }
}
