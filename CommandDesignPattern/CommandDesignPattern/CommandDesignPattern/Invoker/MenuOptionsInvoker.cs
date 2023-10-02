

using CommandDesignPattern.CommandDesignPattern.Command.Interface;

namespace CommandDesignPattern.CommandDesignPattern.Invoker
{
    //// The Invoker is associated with one or several commands. It sends a
    // request to the command.

    //The invoker object (i.e. Menu options) does not know how to handle the requests. So, what the Invoker object will do is, he will call the Execute method of the command object.
    public class MenuOptionsInvoker
    {
        private ICommand openCommand;
        private ICommand saveCommand;
        private ICommand closeCommand;

        public MenuOptionsInvoker(ICommand open, ICommand save, ICommand close)
        {
            this.openCommand = open;
            this.saveCommand = save;
            this.closeCommand = close;
        }

        // The Invoker does not depend on concrete command or receiver classes.
        // The Invoker passes a request to a receiver indirectly, by executing a command
        public void clickOpen()
        {
            openCommand.Execute();
        }

        public void clickSave()
        {
            saveCommand.Execute();
        }

        public void clickClose()
        {
            closeCommand.Execute();
        }
    }
}
