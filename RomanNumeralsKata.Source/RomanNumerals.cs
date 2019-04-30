using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata.Source
{
    public class RomanNumerals
    {
        private Dictionary<int, string> _arabicToRoman = new Dictionary<int, string>
        {
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"},
        };

        public string CalculateRomanResult(int arabic)
        {
            var arabicLocated = 0;
            var locatedNumeral = string.Empty;

            var result = string.Empty;

            do
            {
                foreach (var kvp in _arabicToRoman)
                {
                    if (kvp.Key <= arabic)
                    {
                        locatedNumeral = kvp.Value;
                        arabicLocated = kvp.Key;
                        break;
                    }
                }

                arabic = arabic - arabicLocated;
                result = result + locatedNumeral;
            } while (arabic != 0);

            return result;
        }
    }
}
