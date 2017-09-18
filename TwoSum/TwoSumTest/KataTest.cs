using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoSum;

namespace TwoSumTest
{
    [TestClass]
    public class KataTest
    {
        [TestMethod]
        public void Test_Nums_2_7_11_5_And_Target_9_Should_Return_0_1()
        {
            CollectionAssert.AreEqual(new int[] { 0, 1 }, Kata.TwoSum(new int[] { 2, 7, 11, 5 }, 9));
        }

        [TestMethod]
        public void Test_Nums_3_5_12_5_And_Target_10_Should_Return_1_3()
        {
            CollectionAssert.AreEqual(new int[] { 1, 3 }, Kata.TwoSum(new int[] { 3, 5, 12, 5 }, 10));
        }
    }
}
