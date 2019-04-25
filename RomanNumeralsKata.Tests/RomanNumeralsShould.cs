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
        [TestCase(10, "X")]
        [TestCase(2, "II")]
        [TestCase(3,"III")]
        public void NumeralConverter(int arabic, string numeral)
        {
            var romanNumerals = new RomanNumerals();
            var result = romanNumerals.Convert(arabic);
            result.Should().Be(numeral);
        }
    }
}
