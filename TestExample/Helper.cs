using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExample
{
    static class Helper
    {
        static char[] punctuation = { ',', '.', '?', '!', ':', ';' };

        public static bool ContainsLetters(string line)
        {
            return true;
        }

        public static bool StartsWithLetters(string line)
        {
            return false;
        }

        public static bool EndsWithPunctuation(string line)
        {
            return true;
        }

        public static bool ContainsPunctuationInTheMiddle(string line)
        {
            return false;
        }

    }
}
