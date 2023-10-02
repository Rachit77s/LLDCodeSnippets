using AdapterDesignPattern.LanguageTranslatorExample.Adaptee.AdapteeClasses;
using AdapterDesignPattern.LanguageTranslatorExample.Target;
using System;
using System.Collections.Generic;

namespace AdapterDesignPattern.LanguageTranslatorExample.Adapter
{
    // Adapter or Translator
    // Pam can speak and understand both English and French
    // She acts as an Adapter or Translator
    public class LanguageTranslatorAdapter : ITranslatorTarget
    {
        static Dictionary<string, string> _englishFrenchDictionary = new Dictionary<string, string>();
        static Dictionary<string, string> _frenchEnglishDictionary = new Dictionary<string, string>();
        
        DavidAdaptee david = new DavidAdaptee();
        JohnAdaptee  john = new JohnAdaptee();

        // Rachit: Static Constructor
        static LanguageTranslatorAdapter()
        {
            _englishFrenchDictionary.Add("how are you?", "comment allez-vous?");
            _englishFrenchDictionary.Add("I am in USA", "Je suis aux Etats-Unis");
            _frenchEnglishDictionary.Add("Je suis trC(s bien", "I am fine");
            _frenchEnglishDictionary.Add("oC9 C*tes-vous?", "where are you?");
        }

        //public LanguageTranslatorAdapter(DavidAdaptee david, JohnAdaptee john)
        //{
        //    _david = david;
        //    _john = john;
        //}

        public string TranslateAndTellToOtherPerson(string words, string convertToWhichLanguage)
        {
            if (convertToWhichLanguage.Equals("English", StringComparison.InvariantCultureIgnoreCase))
            {
                string EnglishWords = ConvertToEnglish(words);
                Console.WriteLine("\nPam Converted \"" + words + " \" to \"" + EnglishWords + " and send the question to John");
                string EnglishWordsReply = john.AnswerFortheQuestion(EnglishWords);
                Console.WriteLine("Pam Got reply from John in English : " + "\"" + EnglishWordsReply + "\"");
                string FrenchConverted = ConvertToFrench(EnglishWordsReply);
                Console.WriteLine("Pam Converted " + "\"" + EnglishWordsReply + "\"" + " to " + "\"" + FrenchConverted + "\"" + " and send back to David\n");
                return FrenchConverted;
            }
            else if (convertToWhichLanguage.Equals("French", StringComparison.InvariantCultureIgnoreCase))
            {
                string FrenchWords = ConvertToFrench(words);
                Console.WriteLine("\nPam Converted \"" + words + " \" to \"" + FrenchWords + " and send the question to David");
                string FrenchWordsReply = david.AnswerFortheQuestion(FrenchWords);
                Console.WriteLine("Pam Got reply from David in French : " + "\"" + FrenchWordsReply + "\"");
                string EnglishConverted = ConvertToEnglish(FrenchWordsReply);
                Console.WriteLine("Pam Converted " + "\"" + FrenchWordsReply + "\"" + " to " + "\"" + EnglishConverted + "\"" + " and send back to John\n");
                return EnglishConverted;
            }
            else
            {
                return "Sorry Cannot Covert";
            }
        }
        public string ConvertToFrench(string Words)
        {
            return _englishFrenchDictionary[Words];
        }
        public string ConvertToEnglish(string Words)
        {
            return _frenchEnglishDictionary[Words];
        }
    }
}
