using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using RomanNumeralsKata.Source;

namespace RomanNumeralsKata.Tests
{
    [TestFixture]
    public class RomanNumeralsShould
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3,"III")]
        [TestCase(4, "IV")]
        //[TestCase(5, "V")]
        //[TestCase(6, "VI")]
        //[TestCase(7, "VII")]
        //[TestCase(8,"VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(11, "XI")]
        //[TestCase(12, "XII")]
        //[TestCase(13, "XIII")]
        //[TestCase(14, "XIV")]
        //[TestCase(15, "XV")]
        //[TestCase(16, "XVI")]
        //[TestCase(17, "XVII")]
        //[TestCase(18, "XVIII")]
        //[TestCase(19, "XIX")]
        //[TestCase(20, "XX")]
        public void NumeralConverter(int arabic, string numeral)
        {
            var romanNumerals = new RomanNumerals();
            var result = romanNumerals.Convert(arabic);
            result.Should().Be(numeral);
        }
    }
}
