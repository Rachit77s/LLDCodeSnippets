using AdapterDesignPattern.LanguageTranslatorExample.Adaptee.Interfaces;
using AdapterDesignPattern.LanguageTranslatorExample.Adapter;
using AdapterDesignPattern.LanguageTranslatorExample.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.LanguageTranslatorExample.Adaptee.AdapteeClasses
{
    public class DavidAdaptee : IFrenchSpeaker
    {
        public string AskQuestion(string Words)
        {
            Console.WriteLine("Question Asked by David [French Speaker and Can understand only French] : " + Words);
            ITranslatorTarget target = new LanguageTranslatorAdapter();
            string replyFromJohn = target.TranslateAndTellToOtherPerson(Words, "English");
            return replyFromJohn;
        }
        public string AnswerFortheQuestion(string Words)
        {
            string reply = null;
            if (Words.Equals("comment allez-vous?", StringComparison.InvariantCultureIgnoreCase))
            {
                reply = "Je suis très bien";
            }
            return reply;
        }
    }
}
