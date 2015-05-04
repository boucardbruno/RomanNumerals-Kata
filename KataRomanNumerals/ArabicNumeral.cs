using System.Collections.Generic;

namespace KataRomanNumerals
{
    public class ArabicNumeral
    {
        private readonly Dictionary<string, int> _roman2Arabic = new Dictionary<string, int>
        {
            {"M", 1000},
            {"CM", 900},
            {"D",  500},
            {"CD", 400},
            {"C",  100},
            {"XC",  90},
            {"L",   50},
            {"XL",  40},
            {"X",   10},
            {"IX",   9},
            {"V",    5},
            {"IV",   4},
            {"I",    1}                              
        };

        public int ToArabic(string romanNumeral)
        {
            int arabicNumeral = 0;
            while (romanNumeral.Length != 0)
            {
                foreach (var token in _roman2Arabic.Keys)
                {
                    if (romanNumeral.StartsWith(token))
                    {
                        romanNumeral = romanNumeral.Substring(token.Length);
                        arabicNumeral += _roman2Arabic[token];
                    }
                }
            }
            return arabicNumeral;
        }
    }
}