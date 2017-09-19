using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeadAnts;

namespace DeadAntsTest
{
    [TestClass]
    public class KataTest
    {
        [TestMethod]
        public void Test_Two_Ants_Die()
        {
            Assert.AreEqual(2, Kata.FindOutDeadAntsCount("...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t"));
        }

        [TestMethod]
        public void Test_No_Ants_Die()
        {
            Assert.AreEqual(0, Kata.FindOutDeadAntsCount(""));
        }

        [TestMethod]
        public void Test_Three_Ants_Die()
        {
            Assert.AreEqual(3, Kata.FindOutDeadAntsCount("...nant..a.ant..nat.ant.t..ant...ant..ant..ant.anant..t"));
        }
    }
}
