using System;

namespace Solutions
{
    static public class WordSearch
    {
        static bool result;
        static int m, n;
        static public bool Exist(char[][] board, string word)
        {
            m = board.Length;
            n = board[0].Length;
            result = false;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i][j] == word[0])
                    {
                        if (result)
                            break;

                        function(i, j, new bool[m, n], board, word, 0);
                    }
                }
            }
            return result;
        }

        static void function(int i, int j, bool[,] visited, char[][] board, string word, int index)
        {
            if (result)
                return;

            if (i < 0 || i >= m || j < 0 || j >= n)
                return;

            if (visited[i, j] == true)
                return;

            if (board[i][j] == word[index])
            {
                visited[i, j] = true;
                if (index == word.Length - 1)
                {
                    result = true;
                    return;
                }
                index++;
                function(i - 1, j, visited, board, word, index);
                function(i + 1, j, visited, board, word, index);
                function(i, j - 1, visited, board, word, index);
                function(i, j + 1, visited, board, word, index);
                visited[i, j] = false;
            }
            else
            {
                return;
            }
        }
    }
}
