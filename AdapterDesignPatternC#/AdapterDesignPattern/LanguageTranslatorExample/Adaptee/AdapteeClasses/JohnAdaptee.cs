using AdapterDesignPattern.LanguageTranslatorExample.Adaptee.Interfaces;
using AdapterDesignPattern.LanguageTranslatorExample.Adapter;
using AdapterDesignPattern.LanguageTranslatorExample.Target;
using System;

namespace AdapterDesignPattern.LanguageTranslatorExample.Adaptee.AdapteeClasses
{
    //// John is from USA, So he can speak and understand only English
    public class JohnAdaptee : IEnglishSpeaker
    {
        public string AskQuestion(string Words)
        {
            Console.WriteLine("Question Asked by John [English Speaker and Can understand only English] : " + Words);
            ITranslatorTarget target = new LanguageTranslatorAdapter();
            string replyFromDavid = target.TranslateAndTellToOtherPerson(Words, "French");
            return replyFromDavid;
        }

        public string AnswerFortheQuestion(string Words)
        {
            string reply = null;
            if (Words.Equals("where are you?", StringComparison.InvariantCultureIgnoreCase))
            {
                reply = "I am in USA";
            }
            return reply;
        }
    }
}
