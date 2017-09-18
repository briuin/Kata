using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NextBiggerNumber;

namespace NextBiggerNumberTest
{
    [TestClass]
    public class KataTest
    {
        [TestMethod]
        public void Test_Input_12_Will_Output_21()
        {
            Assert.AreEqual(21, Kata.NextBiggerNumber(12));
        }

        [TestMethod]
        public void Test_Input_513_Will_Output_531()
        {
            Assert.AreEqual(531, Kata.NextBiggerNumber(513));
        }

        [TestMethod]
        public void Test_Input_2017_Will_Output_2071()
        {
            Assert.AreEqual(2071, Kata.NextBiggerNumber(2017));
        }

        [TestMethod]
        public void Test_Input_2170_Will_Output_2701()
        {
            Assert.AreEqual(2701, Kata.NextBiggerNumber(2170));
        }

        [TestMethod]
        public void Test_Input_9_Will_Output_negative1()
        {
            Assert.AreEqual(-1, Kata.NextBiggerNumber(9));
        }

        [TestMethod]
        public void Test_Input_111_Will_Output_negative1()
        {
            Assert.AreEqual(-1, Kata.NextBiggerNumber(111));
        }

        [TestMethod]
        public void Test_Input_531_Will_Output_negative1()
        {
            Assert.AreEqual(-1, Kata.NextBiggerNumber(531));
        }

        
    }
}
