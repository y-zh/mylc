using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

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

            if (ten == 1)
            {
                node.next = new ListNode(ten);
            }

            return ret;

        }

        public static int PoorPigs(int buckets, int minutesToDie, int minutesToTest)
        {
            int n = minutesToTest / minutesToDie + 1;

            return (int)Math.Ceiling(Math.Log(buckets, n));
        }

        public static bool CircularArrayLoop(int[] nums)
        {
            return true;
        }

        public static bool CanJump(int[] nums)
        {
            int last = nums.Length - 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] + i >= last)
                {
                    last = i;
                }
            }
            return last == 0;
        }

        public static string LongestPalindrome(string s)
        {
            int len = s.Length;

            //edge case
            if (len == 0) return null;
            if (len == 1) return s;

            //normal case
            string ret = "";
            for (int i = 1; i < len - 1; i++)
            {
                string palindrome;

                // TODO: use StringBuilder to optimize
                // TODO: consider letting i jump j since j chars after pos i have been checked already.  

                // AA
                if (s[i] == s[i + 1])
                {
                    palindrome = new string(s[i], 2);

                    int j = 1;
                    while (i - j >= 0 && i + 1 + j < len)
                    {
                        if (s[i - j] == s[i + 1 + j])
                        {
                            palindrome = s[i - j].ToString() + palindrome + s[i + 1 + j].ToString();
                        }
                        j++;
                    }

                    if (palindrome.Length > ret.Length) ret = palindrome;
                }

                // ABA
                if (s[i - 1] == s[i + 1])
                {
                    palindrome = new StringBuilder().Append(s[i - 1]).Append(s[i]).Append(s[i + 1]).ToString();
                    int j = 2;
                    while (i - j >= 0 && i + j < len)
                    {
                        if (s[i - j] == s[i + j])
                        {
                            palindrome = new StringBuilder(palindrome).Insert(0, s[i - j]).Append(s[i + j]).ToString();
                        }
                        j++;
                    }
                    if (palindrome.Length > ret.Length) ret = palindrome;
                }
            }

            return ret;
        }

        public static int MinMutation(string start, string end, string[] bank)
        {
            return 0;
        }

        public static string Convert(string s, int numRows)
        {
            int len = s.Length;

            //edge case
            if (len == 0) return "";
            if (numRows <= 1) return s;

            // main case
            StringBuilder ret = new StringBuilder(len);

            int rows = numRows - 1;
            int cols = len / rows;
            if (len % rows > 0) cols++;

            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i < rows && j % 2 == 0 && j * rows + i < len)
                    {
                        ret.Append(s[j * rows + i]);
                    }
                    else if (i > 0 && j % 2 == 1 && (j + 1) * rows - i < len)
                    {
                        ret.Append(s[(j + 1) * rows - i]);
                    }
                }
            }


            return ret.ToString();
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            int len = nums.Length;

            if (len < 3)
                return null;

            IList<IList<int>> ret = new List<IList<int>>(len);
            Array.Sort(nums);

            for (int i = 0; i < len - 2; i++)
            {
                int j = i + 1;
                int k = len - 1;
                while (j < k)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    if (sum == 0)
                    {
                        List<int> rec = new List<int>(3);
                        rec.Add(nums[i]);
                        rec.Add(nums[j]);
                        rec.Add(nums[k]);
                        ret.Add(rec);
                        j++;
                        k--;
                    }
                    else if (sum > 0)
                    {
                        k--;
                    }
                    else // if(sum < 0)
                    {
                        j++;
                    }
                }
            }


            return ret;
        }

        public static IList<string> LetterCombinations(string digits)
        {
            if (digits == null || digits.Length == 0)
            {
                return null;
            }

            string[] dials = { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

            Queue<string> temp = new Queue<string>();
            temp.Enqueue("");

            for (int i = 0; i < digits.Length; i++)
            {
                string str = dials[int.Parse(digits[i].ToString())];

                int n = temp.Count;
                for (int j = 0; j < n; j++)
                {
                    string s = temp.Dequeue();
                    for (int k = 0; k < str.Length; k++)
                    {
                        temp.Enqueue(s + str[k]);
                    }
                }
            }

            return temp.ToArray();
        }

        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode p = head;
            ListNode q = head;

            for (int i = 0; i < n; i++)
            {
                p = p.next;
            }

            if (p == null)
            {
                return head.next;
            }
            else
            {
                p = p.next;
            }

            while (p != null)
            {
                p = p.next;
                q = q.next;
            }
            q.next = q.next.next;

            return head;
        }

        public static bool ParenthesesIsValid(string s)
        {
            Stack<char> parenttheses = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                if (ch == '(' || ch == '[' || ch == '{')
                {
                    parenttheses.Push(ch);
                }


                if (ch == ')')
                {
                    if (parenttheses.Count == 0 || parenttheses.Pop() != '(')
                        return false;
                }
                if (ch == ']')
                {
                    if (parenttheses.Count == 0 || parenttheses.Pop() != '[')
                        return false;
                }
                if (ch == '}')
                {
                    if (parenttheses.Count == 0 || parenttheses.Pop() != '{')
                        return false;
                }
            }

            return parenttheses.Count == 0;
        }

        public static IList<string> GenerateParenthesis(int n)
        {
            if (n <= 1)
                return new List<string>() { "()" };

            IList<string> ret = new List<string>();
            IList<string> list = GenerateParenthesis(n - 1);

            for (int i = 0; i < list.Count; i++)
            {
                string str = list[i];

                if (!ret.Contains(str + "()"))
                {
                    ret.Add(str + "()");
                }

                if (!ret.Contains("()" + str))
                {
                    ret.Add("()" + str);
                }

                if (!ret.Contains("(" + str + ")"))
                {
                    ret.Add("(" + str + ")");
                }
            }

            return ret;
        }
        
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }

            if (l2 == null)
            {
                return l1;
            }

            ListNode ret = new ListNode(0);
            if (l1.val <= l2.val)
            {
                ret.val = l1.val;
                ret.next = MergeTwoLists(l1.next, l2);
            }
            else //l1.val > l2.val
            {
                ret.val = l2.val;
                ret.next = MergeTwoLists(l1, l2.next);
            }

            return ret;
        }

        public static ListNode MergeKLists(ListNode[] lists)
        {
            ListNode ret = lists[0];

            for (int i = 1; i < lists.Length; i++)
            {
                ret = MergeTwoLists(ret, lists[i]);
            }

            return ret;
        }
    }
}

