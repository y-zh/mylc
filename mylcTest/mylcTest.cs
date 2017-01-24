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

    [TestClass]
    public class AddTwoNumbersTest
    {
        [TestMethod]
        public void Test1()
        {
            ListNode n342_1 = new ListNode(2);
            ListNode n342_2 = new ListNode(4);
            ListNode n342_3 = new ListNode(3);
            n342_1.next = n342_2;
            n342_2.next = n342_3;
            n342_3.next = null;

            ListNode n465_1 = new ListNode(5);
            ListNode n465_2 = new ListNode(6);
            ListNode n465_3 = new ListNode(4);
            n465_1.next = n465_2;
            n465_2.next = n465_3;
            n465_3.next = null;

            ListNode ret = Solution.AddTwoNumbers(n342_1, n465_1);

            Assert.AreEqual(ret.val, 7);
            Assert.AreEqual(ret.next.val, 0);
            Assert.AreEqual(ret.next.next.val, 8);
        }

        [TestMethod]
        public void Test2()
        {
            ListNode n342_1 = new ListNode(2);
            ListNode n342_2 = new ListNode(4);
            ListNode n342_3 = new ListNode(3);
            n342_1.next = n342_2;
            n342_2.next = n342_3;
            n342_3.next = null;

            ListNode n9_1 = new ListNode(9);
            n9_1.next = null;

            ListNode ret = Solution.AddTwoNumbers(n342_1, n9_1);

            Assert.AreEqual(ret.val, 1);
            Assert.AreEqual(ret.next.val, 5);
            Assert.AreEqual(ret.next.next.val, 3);
        }


        [TestMethod]
        public void Test3()
        {
            ListNode n342_1 = new ListNode(2);
            ListNode n342_2 = new ListNode(4);
            ListNode n342_3 = new ListNode(3);
            n342_1.next = n342_2;
            n342_2.next = n342_3;
            n342_3.next = null;

            ListNode n987_1 = new ListNode(7);
            ListNode n987_2 = new ListNode(8);
            ListNode n987_3 = new ListNode(9);
            n987_1.next = n987_2;
            n987_2.next = n987_3;
            n987_3.next = null;

            ListNode ret = Solution.AddTwoNumbers(n342_1, n987_1);

            Assert.AreEqual(ret.val, 9);
            Assert.AreEqual(ret.next.val, 2);
            Assert.AreEqual(ret.next.next.val, 3);
            Assert.AreEqual(ret.next.next.next.val, 1);
        }
    }
}
