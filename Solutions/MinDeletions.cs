using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public static class MinDeletions
    {
        public static int function(string s)
        {
            int result = 0;
            Dictionary<char, int> d = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (d.ContainsKey(s[i]))
                {
                    d[s[i]] += 1;
                }
                else
                {
                    d.Add(s[i], 1);
                }
            }

            List<int> l = new List<int>();
            foreach (var f in d.Values)
                l.Add(f);

            l.Sort();
            int max_f = l[l.Count - 1];

            for (int i = l.Count - 2; i >= 0; i--)
            {
                if (l[i] >= max_f)
                {
                    int diff = (l[i] - max_f) + 1;
                    if (l[i] - diff < 0)
                    {
                        result += l[i];
                        l[i] = 0;
                        max_f = 0;
                    }
                    else
                    {
                        l[i] -= diff;
                        result += diff;
                        max_f = l[i];
                    }
                }
                else 
                {
                    max_f = l[i];
                }
            }
            return result;
        }
    }
}
