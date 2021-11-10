using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public static class Permutations
    {
        public static IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            result.Add(new List<int>(nums));
            helper(result, 0, nums.Length);
            return result;
        }

        public static void helper(IList<IList<int>> result, int index, int Length)
        {
            if (index == Length - 1)
                return;
            IList<IList<int>> lists = new List<IList<int>>();
            foreach (var l in result)
            {
                for (int i = index + 1; i < Length; i++)
                {
                    IList<int> a = swap(l, index, i);
                    lists.Add(a);
                }
            }
            foreach (var l in lists)
                result.Add(l);

            helper(result, index + 1, Length);
        }

        public static IList<int> swap(IList<int> list, int index, int i)
        {
            IList<int> output = new List<int>();
            int a = list[index];
            int b = list[i];
            for (int j = 0; j < list.Count; j++)
            {
                if (j == index)
                    output.Add(b);
                else if (j == i)
                    output.Add(a);
                else
                    output.Add(list[j]);
            }
            return output;
        }
    }
}
