using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public static class longestrepeatedchar
    {
        public static string function(string word)
        {
            int max = -1;
            int start = 0;
            int end = 0;
            int[] indexes = new int[2];
            Stack<char> s = new Stack<char>();
            for (int i = 0; i < word.Length; i++)
            {
                if (s.Count == 0)
                {
                    s.Push(word[i]);
                    end = i;
                    continue;
                }

                if (s.Peek() == word[i])
                {
                    s.Push(word[i]);
                    if (i - start > max)
                    {
                        end = i;
                        max = i - start;
                        indexes[0] = start;
                        indexes[1] = end;
                    }
                }
                else
                {
                    s.Push(word[i]);
                    start = i;
                    end = i;
                }
            }
            return word.Substring(indexes[0], indexes[1] - indexes[0]);
        }
    }
}
