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

            Assert.AreEqual(6.0, Solution.FindMedianSortedArrays(a, b));          
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

        [TestMethod]
        public void TestEmpty()
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
    public class PoorPigsTest
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(Solution.PoorPigs(1000, 15, 60), 5);
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(Solution.PoorPigs(1000, 15, 61), 5);
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(Solution.PoorPigs(1000, 15, 69), 5);
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


    [TestClass]
    public class LongestPalindromeTest
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual("bab", Solution.LongestPalindrome("babad"));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual("bb", Solution.LongestPalindrome("cbbd"));
        }


        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual("abcddcba", Solution.LongestPalindrome("abcddcba"));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual("aaaaaaaaaaaaaaaaaa", Solution.LongestPalindrome("aaaaaaaaaaaaaaaaaabcaaaaaaaaaaaaaaaaa"));
        }
        
    }

    [TestClass]
    public class ConvertTest
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual("PAHNAPLSIIGYIR", Solution.Convert("PAYPALISHIRING", 3));
        }
    }

    [TestClass]
    public class LetterCombinationsTest
    {
        [TestMethod]
        public void Test1()
        {
            
        }
    }

    [TestClass]
    public class ParenthesesIsValidTest
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(true, Solution.ParenthesesIsValid("(abce[w]{}wwwwwa{(((abc)))abce})"));
            Assert.AreEqual(true, Solution.ParenthesesIsValid("(asdfa)"));
            Assert.AreEqual(true, Solution.ParenthesesIsValid(""));
            Assert.AreEqual(false, Solution.ParenthesesIsValid(")"));
            Assert.AreEqual(true, Solution.ParenthesesIsValid("{{{{{{{{{{}}}}}}}}}}"));
            Assert.AreEqual(false, Solution.ParenthesesIsValid("{}{}[(])"));
        }
    }

    [TestClass]
    public class GenerateParenthesisTest
    {
        [TestMethod]
        public void Test1()
        {
            System.Collections.Generic.IList<string> strs = Solution.GenerateParenthesis(3);

            Assert.AreEqual(5, strs.Count);
            Assert.AreEqual(true, strs.Contains("((()))"));
            Assert.AreEqual(true, strs.Contains("(()())"));
            Assert.AreEqual(true, strs.Contains("(())()"));
            Assert.AreEqual(true, strs.Contains("()(())"));
            Assert.AreEqual(true, strs.Contains("()()()"));
        }
    }

    [TestClass]
    public class MergeKListsTest
    {
        [TestMethod]
        public void Test1()
        {
            ListNode n1 = new ListNode(2);
            ListNode n2 = new ListNode(6);
            ListNode n3 = new ListNode(12);
            n1.next = n2;
            n2.next = n3;
            n3.next = null;

            ListNode m1 = new ListNode(3);
            ListNode m2 = new ListNode(8);
            ListNode m3 = new ListNode(11);
            m1.next = m2;
            m2.next = m3;
            m3.next = null;

            ListNode ret = Solution.MergeTwoLists(n1, m1);

            Assert.AreEqual(2, ret.val);
            ret = ret.next;
            Assert.AreEqual(3, ret.val);
            ret = ret.next;
            Assert.AreEqual(6, ret.val);
            ret = ret.next;
            Assert.AreEqual(8, ret.val);
            ret = ret.next;
            Assert.AreEqual(11, ret.val);
            ret = ret.next;
            Assert.AreEqual(12, ret.val);
            ret = ret.next;
            Assert.AreEqual(null, ret);
        }

        [TestMethod]
        public void Test2()
        {
            ListNode n1 = new ListNode(2);
            ListNode n2 = new ListNode(6);
            ListNode n3 = new ListNode(12);
            n1.next = n2;
            n2.next = n3;
            n3.next = null;

            ListNode m1 = new ListNode(3);
            ListNode m2 = new ListNode(8);
            ListNode m3 = new ListNode(11);
            m1.next = m2;
            m2.next = m3;
            m3.next = null;

            ListNode p1 = new ListNode(4);
            ListNode p2 = new ListNode(5);
            ListNode p3 = new ListNode(7);
            p1.next = p2;
            p2.next = p3;
            p3.next = null;

            ListNode q1 = new ListNode(13);
            ListNode q2 = new ListNode(16);
            ListNode q3 = new ListNode(17);
            q1.next = q2;
            q2.next = q3;
            q3.next = null;

            ListNode r1 = new ListNode(1);
            ListNode r2 = new ListNode(20);
            ListNode r3 = new ListNode(21);
            r1.next = r2;
            r2.next = r3;
            r3.next = null;

            ListNode[] lists = new ListNode[5];
            lists[0] = n1;
            lists[1] = m1;
            lists[2] = p1;
            lists[3] = q1;
            lists[4] = r1;
            ListNode ret = Solution.MergeKLists(lists);

            Assert.AreEqual(1, ret.val);
            ret = ret.next;
            Assert.AreEqual(2, ret.val);
            ret = ret.next;
            Assert.AreEqual(3, ret.val);
            ret = ret.next;
            Assert.AreEqual(4, ret.val);
            ret = ret.next;
            Assert.AreEqual(5, ret.val);
            ret = ret.next;
            Assert.AreEqual(6, ret.val);
            ret = ret.next;
            Assert.AreEqual(7, ret.val);
            ret = ret.next;
            Assert.AreEqual(8, ret.val);
            ret = ret.next;
            Assert.AreEqual(11, ret.val);
            ret = ret.next;
            Assert.AreEqual(12, ret.val);
            ret = ret.next;
            Assert.AreEqual(13, ret.val);
            ret = ret.next;
            Assert.AreEqual(16, ret.val);
            ret = ret.next;
            Assert.AreEqual(17, ret.val);
            ret = ret.next;
            Assert.AreEqual(20, ret.val);
            ret = ret.next;
            Assert.AreEqual(21, ret.val);
            ret = ret.next;
            Assert.AreEqual(null, ret);
        }
    }

    [TestClass]
    public class TotalNQueensTest
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(1, Solution.TotalNQueens(1));
            Assert.AreEqual(92, Solution.TotalNQueens(8));
            Assert.AreEqual(724, Solution.TotalNQueens(10));
            Assert.AreEqual(14200, Solution.TotalNQueens(12));
            Assert.AreEqual(73712, Solution.TotalNQueens(13));
            Assert.AreEqual(365596, Solution.TotalNQueens(14));
        }
    }

    [TestClass]
    public class MinNumAfterRemoveKDigitsTest
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(1984, Solution.MinNumAfterRemoveKDigits(891984, 2));
            Assert.AreEqual(129, Solution.MinNumAfterRemoveKDigits(61829, 2));
            
        }
    }

    [TestClass]
    public class FindKthLargestTest
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(5, Solution.FindKthLargest(new int[] { 3, 2, 1, 5, 6, 4 }, 2));
        }
    }
}
