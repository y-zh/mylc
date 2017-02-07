using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mylc
{
    class Program
    {
        private static void QuickSort(ref int[] nums, int l, int h)
        {
            if (l >= h)
                return;

            int pivot = nums[l];
            int low = l;
            int high = h;
            
            while (low < high)
            {                
                while(low < high && nums[high] >= pivot)
                {
                    high--;
                }

                if(low < high)
                {
                    nums[low] = nums[high];
                    low++;
                }
                else
                {
                    break;
                }

                while(low < high && nums[low] < pivot)
                {
                    low++;
                }

                if(low < high)
                {
                    nums[high] = nums[low];
                    high--;
                }
                else
                {
                    break;
                }
            }
            nums[low] = pivot;
            QuickSort(ref nums, l, low - 1);
            QuickSort(ref nums, high + 1, h);

            return;
        }

        public static void QuickSort(ref int[] nums)
        {
            QuickSort(ref nums, 0, nums.Length - 1);
        }

        static void Main(string[] args)
        {

            int[] A = new int[] { 1, 3, 4, 2, 8, 7, 3, 2, 5, 6, 9, 10, 1, 1 };

            //QuickSort(ref A);

            //for(int i=0; i<A.Length; i++)
            //{
            //    Console.Write("{0} ", A[i]);
            //}

            for (int i = 0; i < A.Length; i++)
            {
                while (A[i] != i + 1 && A[i] != -1)
                {
                    int index = A[i] - 1;
                    if (A[index] == A[i])
                    {
                        A[i] = -1;
                        Console.Write(A[index]);
                    }
                    else
                    {
                        A[i] = A[index];
                        A[index] = index + 1;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
