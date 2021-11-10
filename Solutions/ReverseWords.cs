using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public static class ReverseWords
    {
        public static string function(string s)
        {
            List<string> data = new List<string>();
            string word = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    if (word != "")
                    {
                        data.Add(word);
                        word = "";
                    }
                    continue;
                }
                word += s[i].ToString();
            }
            data.Add(word);
            string result = "";
            for (int i = data.Count - 1; i >= 0; i--)
            {
                if (data[i] == " ")
                    continue;
                result += data[i];
                if (i != 0)
                    result += " ";
            }
            return result;
        }

    }
}
