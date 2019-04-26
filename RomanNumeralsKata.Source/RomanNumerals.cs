using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata.Source
{
    public class RomanNumerals
    {
        public string Convert(int arabic)
        {
            var arabicToRoman = new Dictionary<int, string>
            {
                {1, "I"},
                //{4, "IV"},
                {5, "V"},
                //{9, "IX"},
                {10, "X"},
                //{11, "XI"},
                //{12, "XII"},
                //{13, "XIII"},
                //{14, "XIV"},
                //{15, "XV"},
                //{16, "XVI"},
                //{17, "XVII"},
                //{18, "XVIII"},
                //{19, "XIX"},
                //{20, "XX"}
            };

            var result = string.Empty;
            if (arabic == 10)
            {
                return "X";
            }

            if (arabic > 10)
            {
                return arabicToRoman[10] + arabicToRoman[1];
            }

            if (arabic / 5 >= 1) result += arabicToRoman[5];
            var remainder = arabic % 5;

            

            if (remainder > 3)
            {
                return arabicToRoman[1] + arabicToRoman[5];
            }

            Enumerable.Range(0,remainder).ToList().ForEach( number => result += arabicToRoman[1] );


            return result;
        }
    }
}
