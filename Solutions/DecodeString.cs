using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public static class DecodeString
    {
        public static string decode(string s)
        {
            string result = "";
            Stack<int> nums = new Stack<int>();
            Stack<string> characters = new Stack<string>();
            string word = "";
            int val = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (Char.IsNumber(c))
                {
                    val = 10 * val + c - '0';
                    continue;
                }
                if(val != 0)
                    nums.Push(val);    
                if (c == '[')
                {
                    string ch = "";
                    i++;
                    while (i < s.Length && !Char.IsNumber(s[i]) && s[i] != ']')
                    {
                        ch += s[i++].ToString();
                        val = 0;
                    }
                    i--;
                    characters.Push(ch);
                    continue;
                }
                if (c == ']')
                {
                    if (nums.Count == 1 && characters.Count == 1)
                    {
                        int n = nums.Pop();
                        string st = characters.Pop();
                        word = st;
                        // result = "";
                        for (int j = 0; j < n; j++)
                            result += word;
                    }
                    else
                    {
                        while (nums.Count > 0 && characters.Count > 0)
                        {
                            int n = nums.Pop();
                            string st = characters.Pop();
                            word = st + result;
                            result = "";
                            for (int j = 0; j < n; j++)
                                result += word;
                        }
                    }
                    continue;
                }
                result += c;
            }
            
           
            return result;
        }
    }
}
