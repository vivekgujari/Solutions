using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public class Main
    {
        static string word = "ABCESEEEFS";
        static char[][] board = new char[][]
        {
            new char[]{'A', 'B', 'C', 'E'},
            new char[]{'S', 'F', 'E', 'S'},
            new char[]{'A', 'D', 'E', 'E'}
        };
        bool result = WordSearch.Exist(board, word);
        
    }
}
