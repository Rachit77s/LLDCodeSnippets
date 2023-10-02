using AdapterDesignPattern.LanguageTranslatorExample.Adaptee.AdapteeClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.LanguageTranslatorExample.Client_Driver_Code
{
    public class ClientProgram
    {
        static void Main1234(string[] args)
        {
            string replyFromDavid = new JohnAdaptee().AskQuestion("how are you?");

            Console.WriteLine("Reply From David [French Speaker can Speak and Understand only French] :  " + replyFromDavid);
            Console.WriteLine();

            string replyFromJohn = new DavidAdaptee().AskQuestion("où êtes-vous?");
            Console.WriteLine("Reply From John [English Speaker can Speak and Understand only English] :  " + replyFromJohn);

            Console.Read();
        }
    }
}
