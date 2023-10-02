using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.LanguageTranslatorExample.Target
{
    // https://dotnettutorials.net/lesson/adapter-design-pattern-real-time-example/
    public interface ITranslatorTarget
   {
       string TranslateAndTellToOtherPerson(string words, string convertToWhichLanguage);
   }
}
