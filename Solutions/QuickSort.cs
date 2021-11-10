using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public static class QuickSort
    {
        public static void sort(int[] array)
        {
            function(array, 0, array.Length - 1);
        }
        private static void function(int[] array, int left, int right)
        {
            if (left < right)
            {
                int p = partition(array, left, right);
                function(array, left, p - 1);
                function(array, p + 1, right);
            }
        }
        public static int partition(int[] array, int low, int high)
        {
            int i = low - 1;
            int pivot = array[high];
            while (low < high)
            {
                if (array[low] < pivot)
                {
                    i++;
                    swap(array, i, low);
                }
                low++;
            }
            
            swap(array, i + 1, high);
            return i + 1;
        }

        private static void swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
