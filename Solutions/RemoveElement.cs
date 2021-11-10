using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    static public class RemoveElement
    {
        public static int function(int[] nums, int val)
        {
            int k = 0;
            List<int> indices = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    k++;
                    indices.Add(i);
                }
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (indices.Count == 0)
                    break;
                if (nums[i] == val)
                {
                    indices.Remove(i);
                    continue;
                }
                int temp = nums[i];
                nums[i] = val;
                nums[indices[0]] = temp;
                indices.RemoveAt(0);
            }
            return k;
        }
    }
}
