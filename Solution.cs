using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mylc
{
    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int len1 = nums1.Length;
            int len2 = nums2.Length;

            if (len1 > len2)
            {
                return FindMedianSortedArrays(nums2, nums1); //make sure a is shorter
            }

            // edge case
            if (len1 == 0)  // a is empty
            {
                return (double)(nums2[(len2 - 1) / 2] + nums2[len2 / 2]) / 2.0;
            }

            if (len1 == 1) // single
            {

            }

            // normal case
            int low = 0, high = len1;
            double l1 = 0.0, r1 = 0.0, l2 = 0.0, r2 = 0.0;
            while (low < high)
            {
                int pos1 = (low + high) / 2;
                int pos2 = (len1 + len2) / 2 - pos1;

                l1 = nums1[pos1 - 1]; r1 = nums1[pos1];
                l2 = nums2[pos2 - 1]; r2 = nums2[pos2];

                if (l1 > r2)
                {
                    high = (low + high) / 2;
                    continue;
                }

                if (r1 < l2)
                {
                    low = (low + high) / 2;
                    continue;
                }

                break;
            }

            if ((len1 + len2) % 2 == 0)
            {
                return (Math.Max(l1, l2) + Math.Min(r1, r2)) / 2.0;
            }
            else
            {
                return Math.Min(r1, r2);
            }
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(target - nums[i]))
                {
                    return new int[] { map[target - nums[i]], i };
                }
                map.Add(nums[i], i);
            }

            return null;
        }

        public static int LengthOfLongestSubstring(string s)
        {
            int len = 0;
            string str = "";
            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                int pos = str.IndexOf(ch);
                if (pos >= 0)
                {
                    str = str.Substring(pos + 1);
                }

                str += ch;

                if (str.Length > len)
                {
                    len = str.Length;
                }
            }

            return len;
        }

        public static int LargestPalindrome(int n)
        {
            if (n == 1)
            {
                return 9;
            }

            int max = (int)Math.Pow(10, n) - 1;
            int min = (int)Math.Pow(10, (n - 1));

            for (int val = max; val > min; val--)
            {
                char[] charArray = val.ToString().ToCharArray();
                Array.Reverse(charArray);
                long prod = val * (int)Math.Pow(10, n) + int.Parse(new string(charArray));

                for (int factor = max; factor > min; factor--)
                {
                    if (prod % factor == 0) // found
                    {
                        int rem = (int)prod / factor;
                        if (rem < max && rem > min)
                            return (int)(prod % 1337);
                    }
                }
            }

            return 0;

        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode l = l1;
            ListNode r = l2;
            ListNode ret = null;

            //edge case
            if (l1 == null)
            {
                return l2;
            }
            else if (l2 == null)
            {
                return l1;
            }

            // normal case
            int ten = 0;

            ListNode node = null;

            do
            {
                int lv = (l == null ? 0 : l.val);
                int rv = (r == null ? 0 : r.val);
                int n = lv + rv + ten;
                ten = n / 10;

                ListNode nd = new ListNode(n % 10);
                if (node == null) //head
                {
                    node = nd;
                    ret = nd;
                }
                else // normal node
                {
                    node.next = nd;
                }

                if (l != null)
                {
                    l = l.next;
                }

                if (r != null)
                {
                    r = r.next;
                }
                node = nd;
            }
            while (l != null || r != null);

            if(ten == 1)
            {
                node.next = new ListNode(ten);
            }

            return ret;

        }

    }
}
