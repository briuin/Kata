using System;
using NUnit.Framework;

namespace NextSmallerNumber
{
    [TestFixture]
    public class KataTest
    {
        [TestCase(21, 12)]
        [TestCase(531, 513)]
        [TestCase(2071, 2017)]
        [TestCase(9, -1)]
        [TestCase(111, -1)]
        [TestCase(135, -1)]
        [TestCase(1027, -1)]
        public void TestNextSmallerNumber(int input, int expectedResult)
        {
            var actual = Kata.GetNextSmallerNumber(input);
            Assert.AreEqual(expectedResult, actual);
        }
    }
}
