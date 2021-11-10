using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public static class MergeSort
    {
        public static void sort(int[] array)
        {
            if (array.Length <= 1)
                return;
            int middle = array.Length / 2;
            int[] left = new int[middle];
            int[] right = new int[array.Length - middle];
            for (int i = 0; i < middle; i++)
            {
                left[i] = array[i];
            }
            for (int i = middle; i < array.Length; i++)
            {
                right[i - middle] = array[i];
            }

            sort(left);
            sort(right);
            merge(array, left, right);
        }

        
        public static void merge(int[] result, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                {
                    result[k++] = left[i++];
                }
                else
                {
                    result[k++] = right[j++];
                }
            }
            while (i < left.Length)
                result[k++] = left[i++];

            while (j < right.Length)
                result[k++] = right[j++];
        }
    }
}
