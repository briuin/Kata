using System.Collections.Generic;
using NUnit.Framework;

namespace RomanNumerals
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase("I", 1)]
        [TestCase("V", 5)]
        [TestCase("IV", 4)]
        [TestCase("VI", 6)]
        [TestCase("IX", 9)]
        [TestCase("CMXCIX", 999)]
        [TestCase("DCXXIX", 629)]
        [TestCase("MMMCMXCIX", 3999)]
        public void TestMethod1(string input, int expect)
        {
            var result = RomeToNumber.Translate(input);
            Assert.AreEqual(expect, result);
        }
    }

    public class RomeToNumber   
    {
        static readonly Dictionary<char, int> Dict = new Dictionary<char, int>()
        {
            {'I',1 },
            {'V',5 },
            {'X',10 },
            {'L',50 },
            {'C',100 },
            {'D',500 },
            {'M',1000 },
        };
        public static int Translate(string s)
        {
            var digitArray = s.ToCharArray();
            var result = 0;
            for (var i = digitArray.Length - 1; i >= 0; i--)
            {
                if ( i != digitArray.Length - 1 && Dict[digitArray[i + 1]] > Dict[digitArray[i]])
                {
                    result -= Dict[digitArray[i]];
                    continue;
                }
                result += Dict[digitArray[i]];
            }
            return result;
        }
    }
}
