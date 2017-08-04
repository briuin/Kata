using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringAverage;

namespace StringAverageTest
{
    [TestClass]
    public class KataTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("four", Kata.StringAverage("zero nine five two"));
            Assert.AreEqual("three", Kata.StringAverage("four six two three"));
            Assert.AreEqual("three", Kata.StringAverage("one two three four five"));
            Assert.AreEqual("four", Kata.StringAverage("five four"));
            Assert.AreEqual("zero", Kata.StringAverage("zero zero zero zero zero"));
            Assert.AreEqual("two", Kata.StringAverage("one one eight one"));
            Assert.AreEqual("n/a", Kata.StringAverage(""));
        }
    }
}
