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
            {1, "I"},
            {4, "IV"},
            {5, "V"},
            {9, "IX"},
            {10, "X"},
            //{11, "XI"},
            //{12, "XII"},
            //{13, "XIII"},
            //{14, "XIV"},
            //{15, "XV"},
            //{16, "XVI"},
            //{17, "XVII"},
            //{18, "XVIII"},
            {19, "XIX"},
            //{20, "XX"}
        };

        public string Convert(int arabic)
        {
            _arabicToRoman = _arabicToRoman.OrderByDescending(x => x.Key).ToDictionary(pair => pair.Key, pair => pair.Value);

            var result = string.Empty;

            if (arabic == 19)
            {
                return "XIX";
            }

            if (arabic == 13)
            {
                return "XIII";
            }

            if (arabic > 8 && arabic < 10)
            {
                return _arabicToRoman[1] + _arabicToRoman[10];
            }

            if (arabic == 10)
            {
                return "X";
            }

            if (arabic > 10)
            {
                return _arabicToRoman[10] + _arabicToRoman[1];
            }


            return CalculateRomanResult(arabic);
        }

        private string CalculateRomanResult(int arabic)
        {
            var arabicLocated = 0;
            var locatedNumeral = string.Empty;

            var controlVar = arabic;

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

                controlVar = controlVar - arabicLocated;
                result = result + locatedNumeral;
            } while (controlVar != 0);

            return result;
        }
    }
}
