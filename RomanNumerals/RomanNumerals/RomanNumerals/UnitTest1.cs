﻿using System.Collections.Generic;
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
            char[] digitArray = s.ToCharArray();
            int result = 0;
            //for (int i = digitArray.Length - 1; i >= 0; i--)
            //{
            //    if ( i+1 < digitArray.Length && dict[digitArray[i + 1]] < dict[digitArray[i]])
            //    {
            //        result -= dict[digitArray[i]];

            //    }
            //    result += dict[digitArray[i]];
            //}
            return dict[s];
        }
    }
}
