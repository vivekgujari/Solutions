using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public static class PermuationSequence
    {
        public static string result;
        public static string function(int n, int k)
        {
            result = "";
            List<int> list = new List<int>();
            for (int i = 1; i <= n; i++)
                list.Add(i);
            helper(list, n, k-1);
            return result;
        }

        public static void helper(List<int> list, int n, int k)
        {
            if (list.Count == 0)
                return;

            int permutations_elem = factorial(n-1);
            int number = (k / permutations_elem);
            int k_new = k % permutations_elem;
            result += list[number].ToString();
            list.RemoveAt(number);
            helper(list, n-1, k_new);
        }

        public static int factorial(int num)
        {
           if (num == 0 || num == 1)
                return 1;
            int result = 1;
            for (int i = num; i >= 1; i--)
                result *= i;
            return result;
        }
    }
}
