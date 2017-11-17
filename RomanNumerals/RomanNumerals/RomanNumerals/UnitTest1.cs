using System.Collections.Generic;
using NUnit.Framework;

namespace RomanNumerals
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase("I", 1)]
        [TestCase("V", 5)]
        public void TestMethod1(string input, int expect)
        {
            var result = RomeToNumber.Translate(input);
            Assert.AreEqual(expect, result);
        }
    }

    public class RomeToNumber   
    {
        static Dictionary<string, int> dict = new Dictionary<string, int>()
        {
            {"I",1 },
            {"V",5 }
        };
        public static int Translate(string s)
        {

            return dict[s];
        }
    }
}
