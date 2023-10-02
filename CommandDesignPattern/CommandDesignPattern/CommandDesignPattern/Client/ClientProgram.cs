using CommandDesignPattern.CommandDesignPattern.Command.Interface;
using CommandDesignPattern.CommandDesignPattern.Command.Models;
using CommandDesignPattern.CommandDesignPattern.Invoker;
using CommandDesignPattern.CommandDesignPattern.Receiver;
using System;

namespace CommandDesignPattern.CommandDesignPattern.Client
{
    class ClientProgram
    {
        static void Main(string[] args)
        {
            DocumentReceiver document = new DocumentReceiver();

            // The client will create the command object
            // The command object has the request  (i.e. what to do?). It also has receiver object reference.
            // The receiver object is nothing but the object which will handle the request. The command object also has the Execute method.
            // The execute method will call the receiver object method and the receiver object method will handle the request.
            ICommand openCommand = new OpenCommand(document);
            ICommand saveCommand = new SaveCommand(document);
            ICommand closeCommand = new CloseCommand(document);

            //As per the command design pattern, the command object will be passed to the invoker object. The Invoker does not know how to handle the request. What the invoker will do is, it will call the Execute method of the command object.
            //The execute method of command object will call the receiver object method and the receiver object method will perform the necessary action to handle the request. 

            MenuOptionsInvoker menu = new MenuOptionsInvoker(openCommand, saveCommand, closeCommand);

            menu.clickOpen();
            menu.clickSave();
            menu.clickClose();
            Console.ReadKey();
        }
    }
}
