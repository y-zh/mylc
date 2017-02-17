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
                while (low < high && nums[high] >= pivot)
                {
                    high--;
                }

                if (low < high)
                {
                    nums[low] = nums[high];
                    low++;
                }
                else
                {
                    break;
                }

                while (low < high && nums[low] < pivot)
                {
                    low++;
                }

                if (low < high)
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

            //for (int i = 0; i < A.Length; i++)
            //{
            //    while (A[i] != i + 1 && A[i] != -1)
            //    {
            //        int index = A[i] - 1;
            //        if (A[index] == A[i])
            //        {
            //            A[i] = -1;
            //            Console.Write(A[index]);
            //        }
            //        else
            //        {
            //            A[i] = A[index];
            //            A[index] = index + 1;
            //        }
            //    }
            //}


            string inputString = Console.ReadLine(); ;
            int[,] Matrix = new int[inputString.Length, inputString.Length];
            int startIndex = 0, endIndex = 0, max = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                for (int j = i; j < inputString.Length; j++)
                {
                    if (i == 0)
                        Matrix[j - i, j] = 1;
                    else if (inputString[j - i] == inputString[j] && Matrix[j - i + 1, j - 1] != 0)
                        Matrix[j - i, j] = Matrix[j - i + 1, j - 1] + 2;

                    if (Matrix[j - i, j] > max)
                    {
                        startIndex = j - i;
                        endIndex = j;
                        max = Matrix[j - i, j];
                    }
                }
            }

            for (int i = startIndex; i <= endIndex; i++)
                Console.Write(inputString[i]);

            Console.ReadKey();
        } 
    }
}
