using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mylc;

namespace mylcTest
{
    [TestClass]
    public class FindMedianSortedArraysTest
    {
        [TestMethod]
        public void Test1()
        {
            int[] a = { 1, 2, 3, 5, 8, 10 };
            int[] b = { 4, 7, 14, 19 };

            Assert.AreEqual(Solution.FindMedianSortedArrays(a, b), 6.0);          
        }

        [TestMethod]
        public void Test2()
        {
            int[] a = { 1, 2, 5, 8, 10 };
            int[] b = { 4, 7, 14, 19 };

            Assert.AreEqual(Solution.FindMedianSortedArrays(a, b), 7.0);
        }

        [TestMethod]
        public void TestSingleElement()
        {
            //int[] a = { 1 };
            //int[] b = { 4, 7, 14, 19 };

            //Assert.AreEqual(Solution.FindMedianSortedArrays(a, b), 4.0);
        }
    }

    [TestClass]
    public class TwoSumTest
    {
        [TestMethod]
        public void Test1()
        {
            int[] ret = Solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            Assert.AreEqual(ret[0], 0);
            Assert.AreEqual(ret[1], 1);
        }
    }

    [TestClass]
    public class LengthOfLongestSubstringTest
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(Solution.LengthOfLongestSubstring("abcabcbb"), 3);
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(Solution.LengthOfLongestSubstring("bbbbb"), 1);
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(Solution.LengthOfLongestSubstring("pwwkew"), 3);
        }
    }


    [TestClass]
    public class LargestPalindromeTest
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(Solution.LargestPalindrome(2), 987);
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(Solution.LargestPalindrome(8), 475);
        }
    }
}
