using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.Games.Backtracking
{
    public class Sudoku
    {
        public static void Solve()
        {
            int[,] board = {
                               {0,0,0,0,0,0,0,0,0},
                               {0,0,0,0,0,0,0,0,0},
                               {0,0,0,0,0,0,0,0,0},
                               {0,0,0,0,0,0,0,0,0},
                               {0,0,0,0,0,0,0,0,0},
                               {0,0,0,0,0,0,0,0,0},
                               {0,0,0,0,0,0,0,0,0},
                               {0,0,0,0,0,0,0,0,0},
                               {0,0,0,0,0,0,0,0,0}
                           };

            print(board);

            solve(board);

            print(board);

        }

        private static void print(int[,] board)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(board[i, j] + "\t");
                }

                Console.Write("\n");
            }
        }

        private static bool solve(int[,] board)
        {
            int[,] status = new int[board.GetLength(0), board.GetLength(1)];
 
            for(int i =0; i<9; i++)
                for (int j = 0; j < 9; j++)
                {
                    status[i, j] = board[i, j] > 0 ? 2 : 0;
                }

            return solve(board, status, 0, 0);

        }

        private static bool solve(int[,] board, int[,] status, int x, int y)
        {
            if (x == 9)
            {
                int count = 0;
                for (int i = 0; i < 9; i++)
                    for (int j = 0; j < 9; j++)
                        count += (status[i, j] > 1 ? 1 : 0);

                if (count == 81)
                    return true;
                else
                    return false;
            }

            if (status[x, y] >= 1)
            {
                int nextX = x;
                int nextY = y;

                if (nextX == 9)
                {
                    nextX = x + 1;
                    nextY = 0;
                }
                return solve(board, status, nextX, nextY);
            }
            else
            {
                bool[] used = new bool[9];
                for (int i = 0; i < 9; i++)
                {
                    if (status[x, i] > 0)
                        used[board[x, i] - 1] = true;
                }

                for (int i = 0; i < 9; i++)
                {
                    if (status[i, y] > 0)
                        used[board[i, y] - 1] = true;
                }

                for (int i = x - (x % 3); i < x - (x % 3) + 3; i++)
                {
                    for (int j = y - (y % 3); j < y - (y % 3) + 3; j++)
                    {
                        if (status[i, j] > 0)
                        used[board[i, j] - 1] = true;
                    }
                }

                for(int i =0; i< used.Length; i++)
                {
                    if (!used[i])
                    {
                        status[x, y] = 1;
                        board[x, y] = 1;

                        int nextX = x;
                        int nextY = y + 1;

                        if (nextY == 9)
                        {
                            nextX += 1;
                            nextY = 0;
                        }

                        if(solve(board, status, nextX, nextY))
                        {
                            return true;
                        }

                        for(int m =0; m<9; m++)
                            for(int n=0; n<9; n++)
                                if(m>x || (m==x && n>=y))
                                {
                                    if(status[m,n] ==1)
                                    {
                                        status[m,n]=0;
                                        board[m,n] = 0;
                                    }
                                }
                    }
                }
            }

            return false;
        }
    }
}
