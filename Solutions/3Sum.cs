using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    static public class _3Sum
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (nums.Length == 3)
            {
                if (nums[0] + nums[1] + nums[2] == 0)
                {
                    result.Add(new List<int>() { nums[0], nums[1], nums[2] });
                    return result;
                }
            }

            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 3; i++)
            {
                if (i != 0 && nums[i] == nums[i - 1])
                    continue;

                int j = i + 1;
                int k = nums.Length - 1;

                while (j < k)
                {
                    while (j != i + 1 && nums[j] == nums[j - 1])
                    {
                        j++;
                        break;
                    }
                    while (k != nums.Length - 1 && nums[k] == nums[k + 1])
                    {
                        k--;
                        break;
                    }

                    int sum = nums[i] + nums[j] + nums[k];
                    if (sum == 0 && j < k)
                    {
                        result.Add(new List<int>() { nums[i], nums[j], nums[k] });
                        j++;
                        k--;
                    }
                    if (sum < 0)
                    {
                        j++;
                    }
                    if (sum > 0)
                    {
                        k--;
                    }
                }
            }
            return result;
        }

    }
}
