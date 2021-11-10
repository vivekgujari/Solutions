using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public static class InsertInterval
    {
        public static void function(int[][] intervals, int[] newinterval)
        {
            int[] products = new int[intervals.Length];
            for (int i = 0; i < intervals.Length; i++)
            {
                products[i] = intervals[i][0] * intervals[i][1];
            }
            int p = newinterval[0] * newinterval[1];

            int l = 0;
            int r = 0;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] > p)
                {
                    
                }

            }
        }
    }
}
