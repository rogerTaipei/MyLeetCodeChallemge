using CommonBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeEasy
{
    public class MergeTwoSortedArray : ICommonFunc
    {
        public object ExecuteCommand(object obj)
        {
            //int[] x1 = { 1, 2, 5, 6, 7, 11, 13, 15, 19 };
            //int[] x2 = { 2, 8,16,23,46};
            int[] x1 = {};
            int[] x2 = {1};
            Merge(x1, x1.Length, x2, x2.Length);
            return null;
        }

        public string GetFuncDescription()
        {
            return CommonString.MergeSortedArrayDesc;
        }

        public string GetFuncTitle()
        {
            return CommonString.MergeSortedArray;
        }

        public object GetUI()
        {
            return null;
        }

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            if (m == 0)
            {
                nums1 = nums2;
                return;
            }

            if (n == 0)
            {
                return;
            }

            int[] result = new int[m + n];
            for (int i = 0; i < result.Length; ++i) result[i] = nums1[0];

            int num1Index = 0;
            int num2Index = 0;
            int resultIndex = 0;
            while (num2Index < n)
            {
                while (num1Index < m)
                {
                    if (nums2[num2Index] < nums1[num1Index])
                    {
                        // fill num2[num2Index]
                        result[resultIndex] = nums2[num2Index];
                        num2Index++;
                        resultIndex++;
                    }
                    else if (nums2[num2Index] > nums1[num1Index])
                    {
                        // fill num1[num1Index]
                        result[resultIndex] = nums1[num1Index];
                        num1Index++;
                        resultIndex++;
                    }
                    else if (nums2[num2Index] == nums1[num1Index])
                    {
                        result[resultIndex] = nums1[num1Index];
                        num1Index++;
                        num2Index++;
                        resultIndex++;
                    }
                }
                result[resultIndex] = nums2[num2Index];
                num2Index++;
                resultIndex++;
            }

            nums1 = new int[resultIndex + 1];
            for (int i = 0; i <= resultIndex; ++i) nums1[i] = result[i];
        }
    }
}
