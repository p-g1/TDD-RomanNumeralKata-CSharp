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
            if (arabic == 10)
            {
                return "X";
            }

            if (arabic == 2)
            {
                return "II";
            }

            if (arabic == 3)
            {
                return "III";
            }


            return "I";
        }
    }
}
